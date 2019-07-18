//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2019.LiveContest.Metamodels.Docbook
{
    
    
    /// <summary>
    /// The default implementation of the Article class
    /// </summary>
    [XmlNamespaceAttribute("https://www.transformation-tool-contest.eu/2019/docbook")]
    [XmlNamespacePrefixAttribute("docb")]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2019/docbook#//Article")]
    [DebuggerDisplayAttribute("Article {Id}")]
    public partial class Article : TitledElement, IArticle, IModelElement
    {
        
        private static Lazy<ITypedElement> _sections_1Reference = new Lazy<ITypedElement>(RetrieveSections_1Reference);
        
        /// <summary>
        /// The backing field for the Sections_1 property
        /// </summary>
        private ObservableCompositionOrderedSet<ISect1> _sections_1;
        
        private static IClass _classInstance;
        
        public Article()
        {
            this._sections_1 = new ObservableCompositionOrderedSet<ISect1>(this);
            this._sections_1.CollectionChanging += this.Sections_1CollectionChanging;
            this._sections_1.CollectionChanged += this.Sections_1CollectionChanged;
        }
        
        /// <summary>
        /// The sections_1 property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("sections_1")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public IOrderedSetExpression<ISect1> Sections_1
        {
            get
            {
                return this._sections_1;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ArticleChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ArticleReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/docbook#//Article")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveSections_1Reference()
        {
            return ((ITypedElement)(((ModelElement)(Article.ClassInstance)).Resolve("sections_1")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Sections_1 property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Sections_1CollectionChanging(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanging("Sections_1", e, _sections_1Reference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Sections_1 property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Sections_1CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Sections_1", e, _sections_1Reference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int sections_1Index = ModelHelper.IndexOfReference(this.Sections_1, element);
            if ((sections_1Index != -1))
            {
                return ModelHelper.CreatePath("sections_1", sections_1Index);
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "SECTIONS_1"))
            {
                if ((index < this.Sections_1.Count))
                {
                    return this.Sections_1[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "SECTIONS_1"))
            {
                return this._sections_1;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._sections_1))
            {
                return "sections_1";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/docbook#//Article")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Article class
        /// </summary>
        public class ArticleChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Article _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ArticleChildrenCollection(Article parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Sections_1.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Sections_1.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Sections_1.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ISect1 sections_1Casted = item.As<ISect1>();
                if ((sections_1Casted != null))
                {
                    this._parent.Sections_1.Add(sections_1Casted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Sections_1.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Sections_1.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> sections_1Enumerator = this._parent.Sections_1.GetEnumerator();
                try
                {
                    for (
                    ; sections_1Enumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = sections_1Enumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    sections_1Enumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ISect1 sect1Item = item.As<ISect1>();
                if (((sect1Item != null) 
                            && this._parent.Sections_1.Remove(sect1Item)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Sections_1).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Article class
        /// </summary>
        public class ArticleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Article _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ArticleReferencedElementsCollection(Article parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Sections_1.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Sections_1.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Sections_1.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ISect1 sections_1Casted = item.As<ISect1>();
                if ((sections_1Casted != null))
                {
                    this._parent.Sections_1.Add(sections_1Casted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Sections_1.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Sections_1.Contains(item))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> sections_1Enumerator = this._parent.Sections_1.GetEnumerator();
                try
                {
                    for (
                    ; sections_1Enumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = sections_1Enumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    sections_1Enumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ISect1 sect1Item = item.As<ISect1>();
                if (((sect1Item != null) 
                            && this._parent.Sections_1.Remove(sect1Item)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Sections_1).GetEnumerator();
            }
        }
    }
}

