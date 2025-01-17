// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The private link service connection status. </summary>
    public readonly partial struct ConnectionStatus : IEquatable<ConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string ApprovedValue = "Approved";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Pending. </summary>
        public static ConnectionStatus Pending { get; } = new ConnectionStatus(PendingValue);
        /// <summary> Approved. </summary>
        public static ConnectionStatus Approved { get; } = new ConnectionStatus(ApprovedValue);
        /// <summary> Rejected. </summary>
        public static ConnectionStatus Rejected { get; } = new ConnectionStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static ConnectionStatus Disconnected { get; } = new ConnectionStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="ConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(ConnectionStatus left, ConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(ConnectionStatus left, ConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectionStatus"/>. </summary>
        public static implicit operator ConnectionStatus(string value) => new ConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
