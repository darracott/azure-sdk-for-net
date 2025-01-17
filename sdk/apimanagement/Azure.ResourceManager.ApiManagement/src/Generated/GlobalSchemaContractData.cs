// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the GlobalSchemaContract data model. </summary>
    public partial class GlobalSchemaContractData : ResourceData
    {
        /// <summary> Initializes a new instance of GlobalSchemaContractData. </summary>
        public GlobalSchemaContractData()
        {
        }

        /// <summary> Initializes a new instance of GlobalSchemaContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="schemaType"> Schema Type. Immutable. </param>
        /// <param name="description"> Free-form schema entity description. </param>
        /// <param name="value"> Json-encoded string for non json-based schema. </param>
        /// <param name="document"> Global Schema document object for json-based schema formats(e.g. json schema). </param>
        internal GlobalSchemaContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SchemaType? schemaType, string description, BinaryData value, BinaryData document) : base(id, name, resourceType, systemData)
        {
            SchemaType = schemaType;
            Description = description;
            Value = value;
            Document = document;
        }

        /// <summary> Schema Type. Immutable. </summary>
        public SchemaType? SchemaType { get; set; }
        /// <summary> Free-form schema entity description. </summary>
        public string Description { get; set; }
        /// <summary> Json-encoded string for non json-based schema. </summary>
        public BinaryData Value { get; set; }
        /// <summary> Global Schema document object for json-based schema formats(e.g. json schema). </summary>
        public BinaryData Document { get; set; }
    }
}
