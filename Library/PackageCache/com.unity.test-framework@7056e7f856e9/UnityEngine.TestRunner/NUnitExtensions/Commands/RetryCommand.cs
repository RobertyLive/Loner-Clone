 WMI na forma de uma cadeia de caracteres.</summary>
      <param name="query">Uma consulta de evento WMI, que define os eventos para os quais o inspetor escutará.</param>
    </member>
    <member name="M:System.Management.ManagementEventWatcher.#ctor(System.String,System.String)">
      <summary>Inicializa uma nova instância da classe <see cref="T:System.Management.ManagementEventWatcher" /> que escuta eventos em conformidade com a WMI a consulta de evento de WMI determinada. Para essa variante, a consulta e o escopo são especificados como cadeias de caracteres.</summary>
      <param name="scope">O escopo de gerenciamento (namespace) em que o inspetor escuta eventos.</param>
      <param name="query">A consulta que define os eventos para os quais o inspetor escutará.</param>
    </member>
    <member name="M:System.Management.ManagementEventWatcher.#ctor(System.String,System.String,System.Management.EventWatcherOptions)">
      <summary>Inicializa uma nova instância da classe <see cref="T:System.Management.ManagementEventWatcher" /> que escuta eventos em conformidade com a consulta de evento da WMI determinada, de acordo com as opções especificadas. Para essa variante, a consulta e o escopo são especificados como cadeias de caracteres. O objeto de opções pode especificar opções, como informações de tempo limite e contexto.</summary>
      <param name="scope">O escopo de gerenciamento (namespace) em que o inspetor escuta eventos.</param>
      <param name="query">A consulta que define os eventos para os quais o inspetor escutará.</param>
      <param name="options">Um <see cref="T:System.Management.EventWatcherOptions" /> que representa as opções adicionais usadas para inspecionar eventos.</param>
    </member>
    <member name="E:System.Management.ManagementEventWatcher.EventArrived">
      <summary>Ocorre quando um novo evento chega.</summary>
    </member>
    <member name="M:System.Management.ManagementEventWatcher.Finalize">
      <summary>Garante que as chamadas pendentes sejam desmarcadas. Este é o destruidor do objeto. Em C#, os finalizadores são expressos usando a sintaxe do destruidor.</summary>
    </member>
    <member name="P:System.Management.ManagementEventWatcher.Options">
      <summary>Obtém ou define as opções usadas para observar eventos.</summary>
      <returns>As opções de evento usadas para observar eventos.</returns>
    </member>
    <member name="P:System.Management.ManagementEventWatcher.Query">
      <summary>Obtém ou define os critérios a aplicar aos eventos.</summary>
      <returns>A consulta a aplicar aos eventos.</returns>
    </member>
    <member name="P:System.Management.ManagementEventWatcher.Scope">
      <summary>Obtém ou define o escopo no qual inspecionar eventos (namespace ou escopo).</summary>
      <returns>O escopo no qual inspecionar eventos.</returns>
    </member>
    <member name="M:System.Management.ManagementEventWatcher.Start">
      <summary>Assina eventos com a consulta fornecida e os entrega, de forma assíncrona, por meio do evento <see cref="E:System.Management.ManagementEventWatcher.EventArrived" />.</summary>
    </member>
    <member name="M:System.Management.ManagementEventWatcher.Stop">
      <summary>Cancela a assinatura seja ela síncrona ou assíncrona.</summary>
    </member>
    <member name="E:System.Management.ManagementEventWatcher.Stopped">
      <summary>Ocorre quando 