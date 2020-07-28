// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> AuthenticationType to be used for connection. </summary>
    public readonly partial struct Db2AuthenticationType : IEquatable<Db2AuthenticationType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="Db2AuthenticationType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Db2AuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";

        /// <summary> Basic. </summary>
        public static Db2AuthenticationType Basic { get; } = new Db2AuthenticationType(BasicValue);
        /// <summary> Determines if two <see cref="Db2AuthenticationType"/> values are the same. </summary>
        public static bool operator ==(Db2AuthenticationType left, Db2AuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Db2AuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(Db2AuthenticationType left, Db2AuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Db2AuthenticationType"/>. </summary>
        public static implicit operator Db2AuthenticationType(string value) => new Db2AuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Db2AuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Db2AuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}