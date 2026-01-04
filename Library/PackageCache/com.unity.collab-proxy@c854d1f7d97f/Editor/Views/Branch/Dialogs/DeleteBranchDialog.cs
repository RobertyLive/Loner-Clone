<!-- v 1.3.0.30 -->
<command:command xmlns:maml="http://schemas.microsoft.com/maml/2004/10" xmlns:command="http://schemas.microsoft.com/maml/dev/command/2004/10" xmlns:dev="http://schemas.microsoft.com/maml/dev/2004/10">
	<command:details>
		<command:name>
                   Disable-AppxDebug
		</command:name>
		<maml:description>
			<maml:para></maml:para>
		</maml:description>
		<maml:copyright>
			<maml:para></maml:para>
		</maml:copyright>
		<command:verb>Disable</command:verb>
		<command:noun>AppxDebug</command:noun>
		<dev:version></dev:version>
	</command:details>
	<maml:description>
		<maml:para></maml:para>
	</maml:description>
	<!-- Cmdlet syntax section-->
	<command:syntax>
		<command:syntaxItem>
			<maml:name>Disable-AppxDebug</maml:name>
			<command:parameter required="true" variableLength="false" globbing="false" pipelineInput="true (ByPropertyName)" position="named">
				<maml:name>PackageFullName</maml:name>
				<maml:description>
					<maml:para>FullName do Pacote de Aplicativos</maml:para>
				</maml:description>
				<command:parameterValue required="true" variableLength="false">string</command:parameterValue>
			</command:parameter>
			<command:parameter required="false" variableLength="true" globbing="false" pipelineInput="false" position="named">
   			 <maml:name>Confirm</maml:name>
    			<maml:description>
				<maml:para>Solicita a confirmação antes de executar o comando.</maml:para>
    			</maml:description>
			</command:parameter>
			<command:parameter required="false" variableLength="true" globbing="false" pipelineInput="false" position="named">
   			 <maml:name>WhatIf</maml:name>
    			<maml:description>
				<maml:para>Descreve o que aconteceria se o comando fosse executado sem que você o execute de fato.</maml:para>
    			</maml:description>
			</command:parameter>
		</command:syntaxItem>
	</command:syntax>
	<!-- Cmdlet parameter section  -->
	<command:parameters>
		<command:parameter required="true" variableLength="false" globbing="false" pipelineInput="true (ByPropertyName)" position="named">
			<maml:name>PackageFullName</maml:name>
			<maml:description>
				<maml:para>FullName do Pacote de Aplicativos</maml:para>
								
			</maml:description>
			<command:parameterValue required="true" variableLength="false">string</command:parameterValue>
			<dev:type>
				<maml:name>string</maml:name>
				<maml:uri/>
			</dev:type>
			<dev:defaultValue></dev:defaultValue>
		</command:parameter>
			<command:parameter required="false" variableLength="true" globbing="false" pipelineInput="false" position="named">
   			 <maml:name>Confirm</maml:name>
    			<maml:description>
				<maml:para>Solicita a confirmação antes de executar o comando.</maml:para>
    			</maml:description>
    			<command:parameterValue required="false" variableLength="false">SwitchParameter</command:parameterValue>	
				<dev:type>
  				<maml:name>SwitchParameter</maml:name> 
					<maml:uri/> 
					</dev:type>
 			<dev:defaultValue/> 
			</command:parameter>
			<command:parameter required="false" variableLength="true" globbing="false" pipelineInput="false" position="named">
   			 <maml:name>WhatIf</maml:name>
    			<maml:description>
				<maml:para>Descreve o que aconteceria se o comando fosse executado sem que você o execute de fato.</maml:para>
    			</maml:description>
    			<command:parameterValue required="false" variableLength="false">SwitchParameter</command:parameterValue>	
				<dev:type>
  				<maml:name>SwitchParameter</maml:name> 
					<maml:uri/> 
					</dev:type>
 			<dev:defaultValue/> 
			</command:parameter>
	</command:parameters>
	<!-- Input - Output section-->
	<command:inputTypes>
		<command:inputType>
			<dev:type>
				<maml:name></maml:name>
				<maml:uri/>
				<maml:description/>
			</dev:type>
			<maml:description>
				<maml:para>
					<!-- description  -->
					
				</maml:para>
			</maml:description>
		</command:inputType>
	</command:inputTypes>
	<command:returnValues>
		<command:returnValue>
			<dev:type>
				<maml:name></maml:name>
				<maml:uri/>
				<maml:description/>
			</dev:type>   
			<maml:description>
				<maml:para>
					<!-- description  -->
					
				</maml:para>
			</maml:description> 
		</command:returnValue>
	</command:returnValues>
	<!-- Error section-->
	<c