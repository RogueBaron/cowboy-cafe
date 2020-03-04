using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CowboyCafe.Extensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Find the first ancestor in the visual tree that has the speficied type, or null if no ancestor is found
        /// </summary>
        /// <typeparam name="T">they type to search for</typeparam>
        /// <param name="obj"></param>
        /// <returns>the first ancestor of type T or null</returns>
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(obj);

            if(parent is null)
            {
                return null;
            }

            if(parent is T)
            {
                return parent as T;
            }

            return FindAncestor<T>(parent);
        }
    }
}
