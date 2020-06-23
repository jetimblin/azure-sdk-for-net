// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The workflow trigger recurrence. </summary>
    public partial class ScheduleTriggerRecurrence : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of ScheduleTriggerRecurrence. </summary>
        public ScheduleTriggerRecurrence()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ScheduleTriggerRecurrence. </summary>
        /// <param name="frequency"> The frequency. </param>
        /// <param name="interval"> The interval. </param>
        /// <param name="startTime"> The start time. </param>
        /// <param name="endTime"> The end time. </param>
        /// <param name="timeZone"> The time zone. </param>
        /// <param name="schedule"> The recurrence schedule. </param>
        /// <param name="additionalProperties"> . </param>
        internal ScheduleTriggerRecurrence(RecurrenceFrequency? frequency, int? interval, DateTimeOffset? startTime, DateTimeOffset? endTime, string timeZone, RecurrenceSchedule schedule, IDictionary<string, object> additionalProperties)
        {
            Frequency = frequency;
            Interval = interval;
            StartTime = startTime;
            EndTime = endTime;
            TimeZone = timeZone;
            Schedule = schedule;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The frequency. </summary>
        public RecurrenceFrequency? Frequency { get; set; }
        /// <summary> The interval. </summary>
        public int? Interval { get; set; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> The end time. </summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary> The time zone. </summary>
        public string TimeZone { get; set; }
        /// <summary> The recurrence schedule. </summary>
        public RecurrenceSchedule Schedule { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}