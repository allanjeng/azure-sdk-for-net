﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a field in an index definition in Azure Search, which describes the name, data type, and search
    /// behavior of a field.
    /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Index" />
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Initializes a new instance of the Field class.
        /// </summary>
        public Field()
        {
            this.IsRetrievable = true;
        }

        /// <summary>
        /// Initializes a new instance of the Field class with required arguments.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="dataType">The data type of the field.</param>
        public Field(string name, DataType dataType) : this()
        {
            Name = name;
            Type = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the Field class with required arguments.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="analyzerName">The name of the analyzer to use for the field.</param>
        /// <remarks>The new field will automatically be searchable and of type Edm.String.</remarks>
        public Field(string name, AnalyzerName analyzerName)
            : this(name, DataType.String, analyzerName)
        {
            // Do nothing.
        }

        /// <summary>
        /// Initializes a new instance of the Field class with required arguments.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="dataType">The data type of the field.</param>
        /// <param name="analyzerName">The name of the analyzer to use for the field.</param>
        /// <remarks>The new field will automatically be searchable.</remarks>
        public Field(string name, DataType dataType, AnalyzerName analyzerName)
            : this(name, dataType)
        {
            this.Analyzer = analyzerName;
            this.IsSearchable = true;
        }

        /// <summary>
        /// Gets or sets the name of the field.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Naming-rules" />
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the data type of the field.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public DataType Type { get; set; }

        /// <summary>
        /// Gets or sets the name of the analyzer to use for the field at search time and 
        /// indexing time. This option can be used only with searchable fields
        /// and it can't be set together with either SearchAnalyzer or
        /// IndexAnalyzer. Once the analyzer is chosen, it cannot be changed
        /// for the field.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Language-support" /> 
        /// </summary>
        [JsonProperty(PropertyName = "analyzer")]
        public AnalyzerName Analyzer { get; set; }

        /// <summary>
        /// Gets or sets the name of the analyzer used at search time for the field. This
        /// option can be used only with searchable fields. It must be set together
        /// with IndexAnalyzer and it cannot be set together with the Analyzer
        /// option. This analyzer can be updated on an existing field.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Language-support" /> 
        /// </summary>
        [JsonProperty(PropertyName = "searchAnalyzer")]
        public AnalyzerName SearchAnalyzer { get; set; }

        /// <summary>
        /// Gets or sets the name of the analyzer used at indexing time for the field. This
        /// option can be used only with searchable fields. It must be set together
        /// with SearchAnalyzer and it cannot be set together with the Analyzer
        /// option. Once the analyzer is chosen, it cannot be changed for the field.
        /// <see href="https://docs.microsoft.com/rest/api/searchservice/Language-support" /> 
        /// </summary>
        [JsonProperty(PropertyName = "indexAnalyzer")]
        public AnalyzerName IndexAnalyzer { get; set; }

        /// <summary>
        /// Gets or sets the names of the synonym maps for the field. This option enables 
        /// query time synonym expansion for searches against the field 
        /// and can be used only on searchable fields.
        /// </summary>
        [JsonProperty(PropertyName = "synonymMaps")]
        public string[] SynonymMaps { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field is the key of
        /// the index. Valid only for string fields. Every index must have
        /// exactly one key field.
        /// </summary>
        [JsonProperty("key")]
        public bool IsKey { get; set; } 

        /// <summary>
        /// Gets or sets a value indicating whether the field is included in
        /// full-text searches. Valid only for string or string collection
        /// fields. Default is false.
        /// </summary>
        [JsonProperty("searchable")]
        public bool IsSearchable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field can be used in
        /// filter expressions. Default is false.
        /// </summary>
        [JsonProperty("filterable")]
        public bool IsFilterable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field can be used in
        /// orderby expressions. Not valid for string collection fields.
        /// Default is false.
        /// </summary>
        [JsonProperty("sortable")]
        public bool IsSortable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is possible to facet on
        /// this field. Not valid for geo-point fields. Default is false.
        /// </summary>
        [JsonProperty("facetable")]
        public bool IsFacetable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the field can be returned
        /// in a search result. Default is true.
        /// </summary>
        [JsonProperty("retrievable")]
        public bool IsRetrievable { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
