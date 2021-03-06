// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See the LICENSE.txt file in the project root
// for the license information.

void
test_children1(void)
{
    struct flex_item *root = flex_item_new();

    TEST_EQUAL(flex_item_count(root), 0);
    TEST(flex_item_parent(root) == NULL);

    struct flex_item *child1 = flex_item_new();
    flex_item_add(root, child1);

    TEST_EQUAL(flex_item_count(root), 1);
    TEST(flex_item_parent(child1) == root);
    TEST(flex_item_child(root, 0) == child1);

    struct flex_item *child2 = flex_item_new();
    flex_item_add(root, child2);

    TEST_EQUAL(flex_item_count(root), 2);
    TEST(flex_item_parent(child2) == root);
    TEST(flex_item_child(root, 1) == child2);

    TEST(flex_item_delete(root, 0) == child1);

    TEST_EQUAL(flex_item_count(root), 1);
    TEST(flex_item_parent(child1) == NULL);
    TEST(flex_item_child(root, 0) == child2);

    flex_item_insert(root, 0, child1);

    TEST_EQUAL(flex_item_count(root), 2);
    TEST(flex_item_parent(child1) == root);
    TEST(flex_item_child(root, 0) == child1);
    TEST(flex_item_child(root, 1) == child2);

    flex_item_free(root);
}

void
test_children2(void)
{
    struct flex_item *root = flex_item_new();

    struct flex_item *child1 = flex_item_new();
    flex_item_insert(root, 0, child1);

    TEST_EQUAL(flex_item_count(root), 1);
    TEST(flex_item_child(root, 0) == child1);

    struct flex_item *child2 = flex_item_new();
    flex_item_insert(root, 0, child2);

    TEST_EQUAL(flex_item_count(root), 2);
    TEST(flex_item_child(root, 0) == child2);
    TEST(flex_item_child(root, 1) == child1);

    struct flex_item *child3 = flex_item_new();
    flex_item_insert(root, 1, child3);

    TEST_EQUAL(flex_item_count(root), 3);
    TEST(flex_item_child(root, 0) == child2);
    TEST(flex_item_child(root, 1) == child3);
    TEST(flex_item_child(root, 2) == child1);
}

void
test_children3(void)
{
    struct flex_item *root = flex_item_new();

    TEST(flex_item_root(root) == root);

    struct flex_item *child1 = flex_item_new();
    flex_item_add(root, child1);

    TEST(flex_item_root(child1) == root);

    struct flex_item *child2 = flex_item_new();
    flex_item_add(child1, child2);

    TEST(flex_item_root(child2) == root);

    flex_item_delete(root, 0);

    TEST(flex_item_root(child1) == child1);
    TEST(flex_item_root(child2) == child1);

    flex_item_free(child1);
    flex_item_free(root);
}

void
test_children4(void)
{
#define CENTER_ITEM(width, height) \
    ({ \
        struct flex_item *_item = flex_item_with_size(width, height); \
        flex_item_set_align_items(_item, FLEX_ALIGN_CENTER); \
        flex_item_set_justify_content(_item, FLEX_ALIGN_CENTER); \
        _item; \
    })

    struct flex_item *root = CENTER_ITEM(100, 100);

    struct flex_item *child1 = CENTER_ITEM(90, 90);
    flex_item_add(root, child1);

    struct flex_item *child2 = CENTER_ITEM(80, 80);
    flex_item_add(child1, child2);

    struct flex_item *child3 = CENTER_ITEM(70, 70);
    flex_item_add(child2, child3);

    struct flex_item *child4 = CENTER_ITEM(60, 60);
    flex_item_add(child3, child4);

    struct flex_item *child5 = CENTER_ITEM(50, 50);
    flex_item_add(child4, child5);

    flex_layout(root);

    TEST(flex_item_child(root, 0) == child1);
    TEST(flex_item_child(child1, 0) == child2);
    TEST(flex_item_child(child2, 0) == child3);
    TEST(flex_item_child(child3, 0) == child4);
    TEST(flex_item_child(child4, 0) == child5);

    TEST_FRAME_EQUAL(child1, 5, 5, 90, 90);
    TEST_FRAME_EQUAL(child2, 5, 5, 80, 80);
    TEST_FRAME_EQUAL(child3, 5, 5, 70, 70);
    TEST_FRAME_EQUAL(child4, 5, 5, 60, 60);
    TEST_FRAME_EQUAL(child5, 5, 5, 50, 50);

    flex_item_free(root);

#undef CENTER_ITEM
}
