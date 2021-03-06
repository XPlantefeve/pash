/*
	Copyright (c) 2012 Code Owls LLC

	Permission is hereby granted, free of charge, to any person obtaining a copy 
	of this software and associated documentation files (the "Software"), to 
	deal in the Software without restriction, including without limitation the 
	rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
	sell copies of the Software, and to permit persons to whom the Software is 
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in 
	all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
	FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
	IN THE SOFTWARE. 
*/
using System;
using System.Linq;
using System.Management.Automation.Provider;
using System.Xml.Linq;
using Mono.Data.PowerShell.Provider;
using Mono.Data.PowerShell.Provider.PathNodeProcessors;
using Mono.Data.PowerShell.Provider.PathNodes;
using Mono.Data.PowerShell.Paths;

namespace Mono.Data.OData.Provider
{
    public class ODataEntryNodeFactory : ODataNodeFactoryBase, IGetItemContent
    {
        public ODataEntryNodeFactory(Uri uri, XDocument metadata, XElement entry) : base( uri, metadata, entry, "Entry" )
        {
        }

        public override System.Collections.Generic.IEnumerable<INodeFactory> Resolve(IContext context, string nodeName)
        {
            if (null == nodeName)
            {
                return base.Resolve(context, null);
            } 
            
            var ignore = new[] { "edit", "edit-media", "self" };

            return ( from link in GetODataDocument().Descendants(Names.Link).Where(
                       x => !ignore.Contains(x.Attribute(Names.RelAttribute).Value)
                      )
                   let title = link.Attribute(Names.TitleAttribute).Value
                   let fullUri = new Uri(BaseUri, link.Attribute(Names.HrefAttribute).Value)
                   where StringComparer.InvariantCultureIgnoreCase.Equals( title, nodeName )
                   select (INodeFactory)new ODataLinkNodeFactory(fullUri, _metadata, link) ).ToList();                   
        }

        public override System.Collections.Generic.IEnumerable<INodeFactory> GetNodeChildren(IContext context)
        {
            var ignore = new[] {"edit", "edit-media", "self"};

            return ( from link in GetODataDocument( context ).Descendants(Names.Link).Where( 
                       x=> ! ignore.Contains( x.Attribute(Names.RelAttribute).Value )
                      )
                      let fullUri = new Uri( BaseUri, link.Attribute(Names.HrefAttribute).Value )
                   select (INodeFactory) new ODataLinkNodeFactory(fullUri, _metadata, link) ).ToList();                   
        }

        public override string Name
        {
            get
            {
                ODataHelper helper = new ODataHelper(_metadata);
                return helper.GetEntityName(_element) ?? base.Name;
            }
        }
        protected override Uri DocumentUri
        {
            get
            {
                return new Uri( _element.Descendants(Names.Id).First().Value);
            }
        }


        public IContentReader GetContentReader(IContext context)
        {
            var uri = EntityContentUri;
            if( null == uri )
            {
                return null;
            }
            return new ODataEntityContentReader(uri, context);
        }

        Uri EntityContentUri
        {
            get
            {
                var uri = from link in _element.Descendants(Names.Content)
                          let src = link.Attribute( Names.SrcAttribute )
                          where null != src && ! String.IsNullOrEmpty( src.Value )
                          select new Uri(src.Value);

                return uri.FirstOrDefault();
            }
            
        }

        public object GetContentReaderDynamicParameters(IContext context)
        {
            return null;
        }
    }
}
