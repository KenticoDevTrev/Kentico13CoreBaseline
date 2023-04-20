﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.SectionsSystem;

[assembly: RegisterDocumentType(BasicElementContent.CLASS_NAME, typeof(BasicElementContent))]

namespace CMS.DocumentEngine.Types.SectionsSystem
{
    /// <summary>
    /// Represents a content item of type BasicElementContent.
    /// </summary>
    public partial class BasicElementContent : TreeNode
    {
        #region "Constants and variables"

        /// <summary>
        /// The name of the data class.
        /// </summary>
        public const string CLASS_NAME = "SectionsSystem.BasicElementContent";


        /// <summary>
        /// The instance of the class that provides extended API for working with BasicElementContent fields.
        /// </summary>
        private readonly BasicElementContentFields mFields;

        #endregion


        #region "Properties"

        /// <summary>
        /// BasicElementContentID.
        /// </summary>
        [DatabaseIDField]
        public int BasicElementContentID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("BasicElementContentID"), 0);
            }
            set
            {
                SetValue("BasicElementContentID", value);
            }
        }


        /// <summary>
        /// Heading.
        /// </summary>
        [DatabaseField]
        public string ContentHeading
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContentHeading"), @"");
            }
            set
            {
                SetValue("ContentHeading", value);
            }
        }


        /// <summary>
        /// Sub Heading.
        /// </summary>
        [DatabaseField]
        public string ContentSubHeading
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContentSubHeading"), @"");
            }
            set
            {
                SetValue("ContentSubHeading", value);
            }
        }


        /// <summary>
        /// Html Content.
        /// </summary>
        [DatabaseField]
        public string ContentHtml
        {
            get
            {
                return ValidationHelper.GetString(GetValue("ContentHtml"), @"");
            }
            set
            {
                SetValue("ContentHtml", value);
            }
        }


        /// <summary>
        /// Gets an object that provides extended API for working with BasicElementContent fields.
        /// </summary>
        [RegisterProperty]
        public BasicElementContentFields Fields
        {
            get
            {
                return mFields;
            }
        }


        /// <summary>
        /// Provides extended API for working with BasicElementContent fields.
        /// </summary>
        [RegisterAllProperties]
        public partial class BasicElementContentFields : AbstractHierarchicalObject<BasicElementContentFields>
        {
            /// <summary>
            /// The content item of type BasicElementContent that is a target of the extended API.
            /// </summary>
            private readonly BasicElementContent mInstance;


            /// <summary>
            /// Initializes a new instance of the <see cref="BasicElementContentFields" /> class with the specified content item of type BasicElementContent.
            /// </summary>
            /// <param name="instance">The content item of type BasicElementContent that is a target of the extended API.</param>
            public BasicElementContentFields(BasicElementContent instance)
            {
                mInstance = instance;
            }


            /// <summary>
            /// BasicElementContentID.
            /// </summary>
            public int ID
            {
                get
                {
                    return mInstance.BasicElementContentID;
                }
                set
                {
                    mInstance.BasicElementContentID = value;
                }
            }


            /// <summary>
            /// Heading.
            /// </summary>
            public string ContentHeading
            {
                get
                {
                    return mInstance.ContentHeading;
                }
                set
                {
                    mInstance.ContentHeading = value;
                }
            }


            /// <summary>
            /// Sub Heading.
            /// </summary>
            public string ContentSubHeading
            {
                get
                {
                    return mInstance.ContentSubHeading;
                }
                set
                {
                    mInstance.ContentSubHeading = value;
                }
            }


            /// <summary>
            /// Html Content.
            /// </summary>
            public string ContentHtml
            {
                get
                {
                    return mInstance.ContentHtml;
                }
                set
                {
                    mInstance.ContentHtml = value;
                }
            }
        }

        #endregion


        #region "Constructors"

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicElementContent" /> class.
        /// </summary>
        public BasicElementContent() : base(CLASS_NAME)
        {
            mFields = new BasicElementContentFields(this);
        }

        #endregion
    }
}