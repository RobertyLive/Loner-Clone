<?xml version="1.0"?>
<CodeSnippets xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
  <CodeSnippet Format="1.0.0">
    <Header>
      <Title>Exibir resultados na Janela do Console</Title>
      <Author>Microsoft Corporation</Author>
      <Description>Exibe os resultados de uma consulta na Janela do Console.</Description>
      <Shortcut>qConsole</Shortcut>
    </Header>
    <Snippet>
       <Declarations>
        <Literal>
          <ID>queryResult</ID>
          <Type>item</Type>
          <ToolTip>Substituir pelo identificador da consulta.</ToolTip>
          <Default>query</Default>
        </Literal>
        <Literal>
          <ID>item</ID>
          <Type>item</Type>
          <ToolTip>Substituir pelo identificador da variável que representa um item da fonte de dados.</ToolTip>
          <Default>process</Default>
        </Literal>
        <Literal>
          <ID>dataSource</ID>
          <Type>String</Type>
          <ToolTip>Substituir pelo identificador da fonte de dados.</ToolTip>
          <Default>System.Diagnostics.Process.GetProcesses()</Default>
        </Literal>
                 <Literal>
          <ID>field1</ID>
          <Type>String</Type>
          <ToolTip>Substituir pelo identificador do primeiro campo que deseja recuperar da fonte de dados.</ToolTip>
          <Default>ProcessName</Default>
        </Literal>
        <Literal>
          <ID>field2</ID>
          <Type>String</Type>
          <ToolTip>Substituir pelo identificador do segundo campo que deseja recuperar da fonte de dados.</ToolTip>
          <Default>MainWindowTitle</Default>
        </Literal>
        <Literal>
          <ID>alias</ID>
          <Type>String</Type>
          <ToolTip>Substituir pelo alias que deseja dar aos dados.</ToolTip>
          <Default>WindowTitle</Default>
        </Literal>
        <Literal>
          <ID>iterationVar</ID>
          <Type>String</Type>
          <ToolTip>Substituir pelo identificador da variável de iteração que representa um item da consulta.</ToolTip>
          <Default>process</Default>
        </Literal>
      </Declarations>
      <Code Language="VB" Kind="method body"><![CDATA[Dim $queryResult$ = From $item$ In $dataSource$ _
                    Select $item$.$field1$, $alias$ = $item$.$field2$ _
                    Order By $field1$

                 For Each $iterationVar$ In $queryResult$
                     Console.WriteLine($iterationVar$.$field1$ & " " & $iter