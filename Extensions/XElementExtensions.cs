using System.Xml.Linq;

namespace LuCsExtensions.Extensions
{
    public static class XElementExtensions
    {
        /// <summary>
        /// Sort attributes in XML element.
        /// </summary>
        /// <param name="xElement">Related XElement.</param>
        /// <param name="sortAttributes">By Default, Sorting the Parent Attributes is true.</param>
        /// <exception cref="ArgumentNullException">XElement argument is null.</exception>
        public static void Sort(this XElement xElement, bool sortAttributes = true)
        {
            // Make sure there is a valid xElement
            if (xElement == null)
            {
                throw new ArgumentNullException("XElement is null");
            }

            // Sort attributes if needed
            if (sortAttributes)
            {
                List<XAttribute> sortedAttributes = xElement.Attributes().OrderBy(a => a.ToString(), new CaseSensitiveComparer()).ToList();
                sortedAttributes.ForEach(a => a.Remove());
                sortedAttributes.ForEach(a => xElement.Add(a));
            }

            // Sort the children if anything exist
            List<XElement> sortedChildren = xElement.Elements().OrderBy(e => e.Name.ToString(), new CaseSensitiveComparer()).ToList();
            if (xElement.HasElements)
            {
                xElement.RemoveNodes();
                sortedChildren.ForEach(c => c.Sort(sortAttributes));
                sortedChildren.ForEach(c => xElement.Add(c));
            }
        }

        /// <summary>
        /// Remove empty attributes in XML element.
        /// </summary>
        /// <param name="xElement">Element to remove attributes from</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void RemoveEmptyElement(this XElement xElement)
        {
            // Make sure there is a valid xElement
            if (xElement == null)
            {
                throw new ArgumentNullException("XElement is null");
            }

            // Remove Empty/Blanks elements in collection of XML nodes.
            xElement.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();
        }

        /// <summary>
        /// This is required for comparing when sorts xml.
        /// This is case sensitive Comparing. ie, the'A' and 'a' are different. 
        /// </summary>
        private class CaseSensitiveComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return string.Compare(x, y, StringComparison.Ordinal);
            }
        }
    }
}
