// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Indicates the type of data refresh option. </summary>
    public readonly partial struct RefreshType : IEquatable<RefreshType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RefreshType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RefreshType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StaticValue = "Static";
        private const string RefreshPeriodicallyWithFullValue = "RefreshPeriodicallyWithFull";
        private const string RefreshPeriodicallyWithDeltaValue = "RefreshPeriodicallyWithDelta";
        private const string BlockingValue = "Blocking";
        private const string NonblockingValue = "Nonblocking";

        /// <summary> Static. </summary>
        public static RefreshType Static { get; } = new RefreshType(StaticValue);
        /// <summary> RefreshPeriodicallyWithFull. </summary>
        public static RefreshType RefreshPeriodicallyWithFull { get; } = new RefreshType(RefreshPeriodicallyWithFullValue);
        /// <summary> RefreshPeriodicallyWithDelta. </summary>
        public static RefreshType RefreshPeriodicallyWithDelta { get; } = new RefreshType(RefreshPeriodicallyWithDeltaValue);
        /// <summary> Blocking. </summary>
        public static RefreshType Blocking { get; } = new RefreshType(BlockingValue);
        /// <summary> Nonblocking. </summary>
        public static RefreshType Nonblocking { get; } = new RefreshType(NonblockingValue);
        /// <summary> Determines if two <see cref="RefreshType"/> values are the same. </summary>
        public static bool operator ==(RefreshType left, RefreshType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RefreshType"/> values are not the same. </summary>
        public static bool operator !=(RefreshType left, RefreshType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RefreshType"/>. </summary>
        public static implicit operator RefreshType(string value) => new RefreshType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RefreshType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RefreshType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
