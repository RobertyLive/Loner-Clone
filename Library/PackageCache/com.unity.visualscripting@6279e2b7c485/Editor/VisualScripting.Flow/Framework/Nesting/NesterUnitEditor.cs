rameters match anything.
            </summary>
            <remarks>
            The most specific rule that matches a given instrument will be used. The priority of parameters is as follows:
            - MeterName, either an exact match, or the longest prefix match. See <see cref="P:System.Diagnostics.Metrics.Meter.Name"/>.
            - InstrumentName, an exact match. <see cref="P:System.Diagnostics.Metrics.Instrument.Name"/>.
            - ListenerName, an exact match. <see cref="P:Microsoft.Extensions.Diagnostics.Metrics.IMetricsListener.Name"/>.
            - Scopes
            </remarks>
            <param name="meterName">The <see cref="P:System.Diagnostics.Metrics.Meter.Name"/> or prefix.</param>
            <param name="instrumentName">The <see cref="P:System.Diagnostics.Metrics.Instrument.Name"/>.</param>
            <param name="listenerName">The <see cref="P:Microsoft.Extensions.Diagnostics.Metrics.IMetricsListener.Name"/>.</param>
            <param name="s