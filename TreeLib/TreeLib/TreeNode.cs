using System;
using eListLib;

namespace TreeLib {
    class TreeNode<T> {
        private T _data;
        private List<TreeNode<T>> _children;
        private TreeNode<T> _parent;

        public TreeNode(TreeNode<T> cparent, T data) {
            //do something here.
            if (cparent != null) {
                cparent.Children.add(this);
            }
            this.Data = data;
        }

        public T Data {
            get {
                return _data;
            }
            set {
                _data = value;
            }
        }

        public List<TreeNode<T>> Children {
            get {
                return _children;
            }
            set {
                _children = value;
            }
        }

        public TreeNode<T> Parent {
            get {
                return _parent;
            }
            set {
                _parent = value;
            }
        }
    }
}
