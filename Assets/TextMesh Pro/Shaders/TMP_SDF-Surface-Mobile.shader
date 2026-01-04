<<<<<<< HEAD
end-link.sl":"Serra Leoa","ccx.send-link.sm":"San Marino","ccx.send-link.sn":"Senegal","ccx.send-link.so":"Somália","ccx.send-link.sr":"Suriname","ccx.send-link.ss":"Sudão do Sul","ccx.send-link.st":"São Tomé e Príncipe","ccx.send-link.sv":"El Salvador","ccx.send-link.sx":"São Martinho","ccx.send-link.sy":"Síria","ccx.send-link.sz":"Suazilândia","ccx.send-link.ta":"Tristão da Cunha","ccx.send-link.tc":"Ilhas Turcas e Caicos","ccx.send-link.td":"Chade","ccx.send-link.tf":"Territórios Franceses do Sul","ccx.send-link.tg":"Togo","ccx.send-link.th":"Tailândia","ccx.send-link.tj":"Tajiquistão","ccx.send-link.tk":"Tokelau","ccx.send-link.tl":"Timor-Leste","ccx.send-link.tm":"Turcomenistão","ccx.send-link.tn":"Tunísia","ccx.send-link.to":"Tonga","ccx.send-link.tr":"Turquia","ccx.send-link.tt":"Trinidad e Tobago","ccx.send-link.tv":"Tuvalu","ccx.send-link.tw":"Taiwan","ccx.send-link.tz":"Tanzânia","ccx.send-link.ua":"Ucrânia","ccx.send-link.ug":"Uganda","ccx.send-link.um":"Ilhas Menores Distantes dos Estados Unidos","ccx.send-link.us":"Estados Unidos","ccx.send-link.uy":"Uruguai","ccx.send-link.uz":"Uzbequistão","ccx.send-link.va":"Vaticano","ccx.send-link.vc":"São Vicente e Granadinas","ccx.send-link.ve":"Venezuela","ccx.send-link.vg":"Ilhas Virgens Britânicas","ccx.send-link.vi":"Ilhas Virgens Americanas","ccx.send-link.vn":"Vietnã","ccx.send-link.vu":"Vanuatu","ccx.send-link.wf":"Wallis e Futuna","ccx.send-link.ws":"Samoa","ccx.send-link.xk":"Kosovo","ccx.send-link.ye":"Iêmen","ccx.send-link.yt":"Mayotte","ccx.send-link.za":"África do Sul","ccx.send-link.zm":"Zâmbia","ccx.send-link.zw":"Zimbábue","ccx.send-link.zz":"Internacional","ccx.appAction.view-product-details":"Ver detalhes do produto","ccx.appAction.spillover.ariaLabel":"More actions {appName}","ccx.apptile.platformIcon.installed.tooltip":"Instalado neste dispositivo","ccx.appAction.open-in-browser":"Abrir no navegador","ccx.appAction.use-for-free":"Usar gratuitamente","ccx.appAction.get-mobile-app":"Baixar o aplicativo para dispositivos móveis","ccx.appAction.get-tablet-app":"Baixar aplicativo para tablet","ccx.appAction.download":"Baixar","ccx.tile-list-view.view-more":"Exibir mais","ccx.tile-list-view.view-less":"Exibir menos","ccx.top-rail.category.disabled.tooltip.noPlatforms":"Nenhum aplicativo de {category} está disponível.","ccx.top-rail.category.disabled.tooltip.onePlatform":"Todos os aplicativos de {category} são apenas para {platform}.","ccx.top-rail.category.disabled.tooltip.twoPlatforms":"Todos os aplicativos de {category} são apenas para {platform1} ou {platform2}.","ccx.right-section.no-installed-apps":"Seus aplicativos de desktop instalados aparecerão aqui","ccx.right-section.manage-updates":"Gerenciar atualizações","ccx.right-section.update-count":"{updateCount, plural, one {atualização disponível} other {atualizações disponíveis}}","ccx.right-section.header":"Instalado neste dispositivo","ccx.right-section.more-actions":"Mais ações para atualizações de aplicativos","ccx.appAction.get-addons":"Obter suplementos","ccx.right-section.no-apps-installed":"Não há aplicativos instalados","ccx.right-section.installed.uptodate":"Todos os aplicativos instalados estão atualizados","ccx.right-section.update-in-progress":"Atualização em andamento","ccx.right-section.updates-in-progress":"Atualizações em andamento","ccx.app-access-unavailable":"​​Você não tem mais acesso a este aplicativo. Entre em contato com o administrador para obter mais informa
=======
// Simplified version of the SDF Surface shader :
// - No support for Bevel, Bump or envmap
// - Diffuse only lighting
// - Fully supports only 1 directional light. Other lights can affect it, but it will be per-vertex/SH.

Shader "TextMeshPro/Mobile/Distance Field (Surface)" {

Properties {
	_FaceTex			("Fill Texture", 2D) = "white" {}
	[HDR]_FaceColor		("Fill Color", Color) = (1,1,1,1)
	_FaceDilate			("Face Dilate", Range(-1,1)) = 0

	[HDR]_OutlineColor	("Outline Color", Color) = (0,0,0,1)
	_OutlineTex			("Outline Texture", 2D) = "white" {}
	_OutlineWidth		("Outline Thickness", Range(0, 1)) = 0
	_OutlineSoftness	("Outline Softness", Range(0,1)) = 0

	[HDR]_GlowColor		("Color", Color) = (0, 1, 0, 0.5)
	_GlowOffset			("Offset", Range(-1,1)) = 0
	_GlowInner			("Inner", Range(0,1)) = 0.05
	_GlowOuter			("Outer", Range(0,1)) = 0.05
	_GlowPower			("Falloff", Range(1, 0)) = 0.75

	_WeightNormal		("Weight Normal", float) = 0
	_WeightBold			("Weight Bold", float) = 0.5

	// Should not be directly exposed to the user
	_ShaderFlags		("Flags", float) = 0
	_ScaleRatioA		("Scale RatioA", float) = 1
	_ScaleRatioB		("Scale RatioB", float) = 1
	_ScaleRatioC		("Scale RatioC", float) = 1

	_MainTex			("Font Atlas", 2D) = "white" {}
	_TextureWidth		("Texture Width", float) = 512
	_TextureHeight		("Texture Height", float) = 512
	_GradientScale		("Gradient Scale", float) = 5.0
	_ScaleX				("Scale X", float) = 1.0
	_ScaleY				("Scale Y", float) = 1.0
	_PerspectiveFilter	("Perspective Correction", Range(0, 1)) = 0.875
	_Sharpness			("Sharpness", Range(-1,1)) = 0

	_VertexOffsetX		("Vertex OffsetX", float) = 0
	_VertexOffsetY		("Vertex OffsetY", float) = 0

	_CullMode			("Cull Mode", Float) = 0
	//_MaskCoord		("Mask Coords", vector) = (0,0,0,0)
	//_MaskSoftness		("Mask Softness", float) = 0
}

SubShader {

	Tags {
		"Queue"="Transparent"
		"IgnoreProjector"="True"
		"RenderType"="Transparent"
	}

	LOD 300
	Cull [_CullMode]

	CGPROGRAM
	#pragma surface PixShader Lambert alpha:blend vertex:VertShader noforwardadd nolightmap nodirlightmap
	#pragma target 3.0
	#pragma shader_feature __ GLOW_ON

	#include "TMPro_Properties.cginc"
	#include "TMPro.cginc"

	half _FaceShininess;
	half _OutlineShininess;

	struct Input
	{
		fixed4	color		: COLOR;
		float2	uv_MainTex;
		float2	uv2_FaceTex;
		float2  uv2_OutlineTex;
		float2	param;					// Weight, Scale
		float3	viewDirEnv;
	};

	#include "TMPro_Surface.cginc"

	ENDCG

	// Pass to render object as a shadow caster
	Pass
	{
		Name "Caster"
		Tags { "LightMode" = "ShadowCaster" }
		Offset 1, 1

		Fog {Mode Off}
		ZWrite On ZTest LEqual Cull Off

		CGPROGRAM
		#pragma vertex vert
		#pragma fragment frag
		#pragma multi_compile_shadowcaster
		#include "UnityCG.cginc"

		struct v2f {
			V2F_SHADOW_CASTER;
			float2	uv			: TEXCOORD1;
			float2	uv2			: TEXCOORD3;
			float	alphaClip	: TEXCOORD2;
		};

		uniform float4 _MainTex_ST;
		uniform float4 _OutlineTex_ST;
		float _OutlineWidth;
		float _FaceDilate;
		float _ScaleRatioA;

		v2f vert( appdata_base v )
		{
			v2f o;
			TRANSFER_SHADOW_CASTER(o)
			o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
			o.uv2 = TRANSFORM_TEX(v.texcoord, _OutlineTex);
			o.alphaClip = o.alphaClip = (1.0 - _OutlineWidth * _ScaleRatioA - _FaceDilate * _ScaleRatioA) / 2;
			return o;
		}

		uniform sampler2D _MainTex;

		float4 frag(v2f i) : COLOR
		{
			fixed4 texcol = tex2D(_MainTex, i.uv).a;
			clip(texcol.a - i.alphaClip);
			SHADOW_CASTER_FRAGMENT(i)
		}
		ENDCG
	}
}

CustomEditor "TMPro.EditorUtilities.TMP_SDFShaderGUI"
}
>>>>>>> 0a4af3f404ac9ab9e0b083c4a219a4d93d01bc02
