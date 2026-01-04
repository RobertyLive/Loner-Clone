an" />
			<xsd:element ref="bdo" />

			<!-- <xsd:group ref="specialExtraElements" /> -->
			<xsd:element ref="object" />
			<xsd:element ref="applet" />
			<xsd:element ref="img" />
			<xsd:element ref="map" />
			<xsd:element ref="iframe" />
		</xsd:choice>
	</xsd:group>

	<xsd:group name="fontStyleExtraElements">
		<xsd:choice>
			<xsd:element ref="big" />
			<xsd:element ref="small" />
			<xsd:element ref="font" />
			<xsd:element ref="basefont" />
		</xsd:choice>
	</xsd:group>

	<xsd:group name="fontStyleBasicElements">
		<xsd:choice>
			<xsd:element ref="tt" />
			<xsd:element ref="i" />
			<xsd:element ref="b" />
			<xsd:element ref="u" />
			<xsd:element ref="s" />
			<xsd:element ref="strike" />
		</xsd:choice>
	</xsd:group>
	
	<xsd:group name="fontStyleElements">
		<xsd:choice>
			<!-- <xsd:group ref="fontStyleBasicElements" /> -->
			<xsd:element ref="tt" />
			<xsd:element ref="i" />
			<xsd:element ref="b" />
			<xsd:element ref="u" />
			<xsd:element ref="s" />
			<xsd:element ref="strike" />

			<!-- <xsd:group ref="fontStyleExtraElements" /> -->
			<xsd:element ref="big" />
			<xsd:element ref="small" />
			<xsd:element ref="font" />
			<xsd:element ref="basefont" />
		</xsd:choice>
	</xsd:group>

	<xsd:group name="phraseExtraElements">
		<xsd:choice>
			<xsd:element ref="sub" />
			<xsd:element ref="sup" />
		</xsd:choice>
	</xsd:group>

	<xsd:group name="phraseBasicElements">
		<xsd:choice>
			<xsd:element ref="em" />
			<xsd:element ref="strong" />
			<xsd:element ref="dfn" />
			<xsd:element ref="code" />
			<xsd:element ref="q" />
			<xsd:element ref="samp" />
			<xsd:element ref="kbd" />
			<xsd:element ref="var" />
			<xsd:element ref="cite" />
			<xsd:element ref="abbr" />
			<xsd:element ref="acronym" />
		</xsd:choice>
	</xsd:group>
	
	<xsd:group name="phraseElements">
		<xsd:choice>
			<!-- <xsd:group ref="phraseBasicElements" /> -->
			<xsd:element ref="em" />
			<xsd:element ref="strong" />
			<xsd:element ref="dfn" />
			<xsd:element ref="code" />
			<xsd:element ref="q" />
			<xsd:element ref="samp" />
			<xsd:element ref="kbd" />
			<xsd:element ref="var" />
			<xsd:element ref="cite" />
			<xsd:element ref="abbr" />
			<xsd:element ref="acronym" />
			<!-- <x