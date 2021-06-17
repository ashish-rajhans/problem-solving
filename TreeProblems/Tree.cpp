#include "Tree.h"

using namespace std;

Tree TreeReader::getTreeFromVector(const std::vector<int>& treeData)
{
    Tree tree;
    tree.root = nullptr;

	if (!treeData.empty())
	{
		tree.root = new TreeNode(treeData[0]);

		TreeNode* currentParent = tree.root;
		vector<TreeNode*> nodes;
		nodes.push_back(tree.root);

		for (size_t i = 1; i < treeData.size(); ++i)
		{
			currentParent = nodes[i/2];
			if (treeData[i] != -999999)
			{
				TreeNode* leftNode = new TreeNode(treeData[i]);
				currentParent->left = leftNode;
			}
			if (i + 1 < treeData.size() && treeData[i + 1] != -999999)
			{
				TreeNode* rightNode = new TreeNode(treeData[i + 1]);
				++i;
				currentParent->right = rightNode;
			}
			
		}
	}

	return tree;
}
