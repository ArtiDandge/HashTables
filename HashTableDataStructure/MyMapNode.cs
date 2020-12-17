using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableDataStructure
{
    /// <summary>
    /// MyMapNode is a Generic class and <K,V> generic types that this class is accepting 
    /// </summary>
    /// <typeparam name="K">K is Key </typeparam>
    /// <typeparam name="V">V is Value</typeparam>
    public class MyMapNode<K, V>
    {
        private readonly int size;
        /// <summary>
        /// LinkedList accepting array of generic type 'struct KeyValue<K,V>' structure  
        /// </summary>
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        /// <summary>
        /// Method to get position of key in the array using GetHashCode() method
        /// </summary>
        /// <param name="key">key is Key index for its value</param>
        /// <returns></returns>
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        /// <summary>
        /// Method to get value beased on its key
        /// </summary>
        /// <param name="key">key is Key index for its value</param>
        /// <returns></returns>
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);

        }

        /// <summary>
        /// Method to add Key-Value Pair to the linked list of type KeyValue<K,V>
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        /// <summary>
        /// Method to get linked list based on its position
        /// </summary>
        /// <param name="position">position of linkedlist in array</param>
        /// <returns></returns>
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        /// <summary>
        /// Method to remove word based on given key
        /// </summary>
        /// <param name="key">key</param>
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                Console.WriteLine("Item removed : {0}", foundItem.Value);
                linkedList.Remove(foundItem);                
            }
        }

        /// <summary>
        /// A structure that has Key and Value
        /// </summary>
        /// <typeparam name="k">K is key</typeparam>
        /// <typeparam name="v">V is Value</typeparam>
        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
    }
}
