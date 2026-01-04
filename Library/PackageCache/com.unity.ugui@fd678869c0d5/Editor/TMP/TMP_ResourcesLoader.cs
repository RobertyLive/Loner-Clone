" />
			<xsd:attribute name="MarginHeight" type="xsd:integer" />
			<xsd:attribute name="MarginWidth"	type="xsd:integer" />
			<xsd:attribute name="Scrolling" type="scrollingType" default="auto" />
			<xsd:attribute name="Align" type="imgAlignType" vs:deprecated="true" />
			<xsd:attribute name="Height" />
			<xsd:attribute name="Width" />
		</xsd:complexType>
	</xsd:element>

<!-- alternate Content container for non frame-based rendering -->

	<xsd:element name="noframes">
		<xsd:complexType mixed="true">
			<xsd:choice>
				<xsd:group ref="FlowElements" />
			</xsd:choice>
			<xsd:attributeGroup ref="commonAttributeGroup" />
		</xsd:complexType>
	</xsd:element>

<!--=================== Document Body ====================================-->

	<xsd:element name="body" type="bodyType" />
	
	<xsd:complexType name="bodyType" mixed="true">
		<xsd:choice>
			<xsd:group ref="FlowElements" />
		</xsd:choice>
		<xsd:attributeGroup ref="commonAttributeGroup" />
		<xsd:attributeGroup ref="loadEventsGroup" />
		<xsd:attribute name="Background" type="xsd:anyURI" vs:deprecated="true" vs:preferredextensions=".jpg;.jpeg;.gif;.bmp;.jpe;.png;.dib;.tif;.wmf;.ras;.eps;.pcx;.pcd;.tga;.ashx;.asix" />
		<xsd:attribute name="BgColor" type="colorType" vs:builder="color" vs:deprecated="true" />
		<xsd:attribute name="Text" type="colorType" vs:builder="color" vs:deprecated="true" />
		<xsd:attribute name="Link" type="colorType" vs:builder="color" vs:deprecated="true" />
		<xsd:attribute name="VLink" type="colorType" vs:builder="color" vs:deprecated="true" />
		<xsd:attribute name="ALink" type="colorType" vs:builder="color" vs:deprecated="true" />
	</xsd:complexType>

	<!-- generic Language/style container -->
	<xsd:element name="div"> 
		<xsd:complexType mixed="true">
			<xsd:choice>
				<xsd:group ref="FlowElements" />
			</xsd:choice>
			<xsd:attributeGroup ref="commonAttributeGroup" />
			<xsd:attribute name="Align" type="textAlignType" vs:deprecated="true" />
		</xsd:complexType>
	</xsd:element>

<!--=================== Paragraphs =======================================-->

	<xsd:element name="p">
		<xsd:complexType mixed="true">
			<xsd:choice>
				<xsd:group ref="InlineElements" />
			</xsd:choice>
			<xsd:attributeGroup ref="commonAttributeGroup" />
			<xsd:attribute name="Align" type="textAlignType" default="left" vs:deprecated="true" />
		</xsd:complexType>
	</xsd:element>
	
<!--=================== Headings =========================================-->

	<xsd:element name="h1">
		<xsd:complexType mixed="true">
			<xsd:choice>
				<xsd:group ref="InlineElements" />
			</xsd:choice>
			<xsd:attributeGroup ref="commonAttributeGroup" />
			<xsd:attribute name="Align" type="textAlignType" default="left" vs:deprecated="true" />
		</xsd:complexType>
	</xsd:element>

	<xsd:element name="h2">
		<xsd:complexType mixed="true">
			<xsd:choice>
				<xsd:group ref="InlineElements" />
			</xsd:choice>
			<xsd:attributeGroup ref="commonAttributeGroup" />
			<xsd:attribute name="Align" type="textAlignType" default="left" vs:deprecated="true" />
		</xsd:complexType>
	</xsd:element>

	<xsd:element name="h3">
		<xsd:complexType mixed="true">
			<xsd:choice>
				<xsd:group ref="InlineElements" />
			</xsd:choice>
			<xsd:attributeGroup ref="commonAttributeGroup" />
			<xsd:attribute name="Align" type="textAlignType" default="left" vs:deprecated="true" />
		</xsd:complexType>
	</xsd:element>

	<xsd:element name="h4">
		<xsd:complexType mixed="true">
			<xsd:choice>
				<xsd:group ref="InlineElements" />
			</xsd:choice>
			<xsd:attributeGroup ref="commonAttributeGroup