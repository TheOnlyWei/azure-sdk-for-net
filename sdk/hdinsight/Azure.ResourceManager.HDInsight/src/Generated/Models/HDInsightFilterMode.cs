// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The filtering mode. Effectively this can enabling or disabling the VM sizes in a particular set.
    /// Serialized Name: FilterMode
    /// </summary>
    public readonly partial struct HDInsightFilterMode : IEquatable<HDInsightFilterMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightFilterMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightFilterMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ExcludeValue = "Exclude";
        private const string IncludeValue = "Include";
        private const string RecommendValue = "Recommend";
        private const string DefaultValue = "Default";

        /// <summary>
        /// Exclude
        /// Serialized Name: FilterMode.Exclude
        /// </summary>
        public static HDInsightFilterMode Exclude { get; } = new HDInsightFilterMode(ExcludeValue);
        /// <summary>
        /// Include
        /// Serialized Name: FilterMode.Include
        /// </summary>
        public static HDInsightFilterMode Include { get; } = new HDInsightFilterMode(IncludeValue);
        /// <summary>
        /// Recommend
        /// Serialized Name: FilterMode.Recommend
        /// </summary>
        public static HDInsightFilterMode Recommend { get; } = new HDInsightFilterMode(RecommendValue);
        /// <summary>
        /// Default
        /// Serialized Name: FilterMode.Default
        /// </summary>
        public static HDInsightFilterMode Default { get; } = new HDInsightFilterMode(DefaultValue);
        /// <summary> Determines if two <see cref="HDInsightFilterMode"/> values are the same. </summary>
        public static bool operator ==(HDInsightFilterMode left, HDInsightFilterMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightFilterMode"/> values are not the same. </summary>
        public static bool operator !=(HDInsightFilterMode left, HDInsightFilterMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightFilterMode"/>. </summary>
        public static implicit operator HDInsightFilterMode(string value) => new HDInsightFilterMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightFilterMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightFilterMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
