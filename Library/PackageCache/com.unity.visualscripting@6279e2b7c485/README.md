<?xml version='1.0' encoding='utf-8' ?>
<xsd:schema 
	xmlns="http://schemas.microsoft.com/intellisense/xhtml-transitional-10"
	xmlns:vs="http://schemas.microsoft.com/Visual-Studio-Intellisense"
	xmlns:xsd="http://www.w3.org/2001/XMLSchema"
	targetnamespace="http://schemas.microsoft.com/intellisense/xhtml-transitional-10"
	vs:clientom="w3c-dom1.tlb" 
	vs:cssschema="CSS 2.1"
	vs:htmlflavor="4.0" 
	vs:ishtmlschema="true" 
	vs:isserverschema="false" 
	vs:succinctfriendlyname="XHTML 1.0 Transitional"
	vs:xhtmlvalidation="true">
	
<!--
	 Warning:																					
	 Warning: 
	 Warning: Do not change the targetNamespace above 
	 Warning: 
	 Warning: 
-->
	<xsd:annotation>
		<xsd:documentation>
			Microsoft Visual Studio .NET schema for XHTML 1.0 Transitional
			Source: http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd
			(with an addition of the RunAt="server" attribute)
		</xsd:documentation>
	</xsd:annotation>

	<xsd:include schemaLocation="CommonHTMLTypes.xsd" />
	<xsd:include schemaLocation="I18Languages.xsd" />

	<xsd:attributeGroup name="coreAttributeGroup">
		<xsd:attributeGroup ref="runat