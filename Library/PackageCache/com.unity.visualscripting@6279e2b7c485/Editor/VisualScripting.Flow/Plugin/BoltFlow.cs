;
uniform SamplerState samplers2D[1] : register(s0);
#ifdef ANGLE_ENABLE_LOOP_FLATTEN
#define LOOP [loop]
#define FLATTEN [flatten]
#else
#define LOOP
#define FLATTEN
#endif

#define ATOMIC_COUNTER_ARRAY_STRIDE 4

// Varyings
static noperspective float4 _vcolor_S0 = {0, 0, 0, 0};
static noperspective float2 _vTransformedCoords_6_S0 = {0, 0};

static float4 out_sk_FragColor = {0, 0, 0, 0};
static float4 gl_FragCoord = float4(0, 0, 0, 0);

cbuffer DriverConstants : register(b1)
{
    float4 dx_ViewCoords : packoffset(c1);
    float2 dx_FragCoordOffset : packoffset(c3);
    float3 dx_DepthFront : packoffset(c2);
    float2 dx_ViewScale : packoffset(c3.z);
    uint dx_Misc : packoffset(c2.w);
    struct SamplerMetadata
    {
        int baseLevel;
        int wrapModes;
        int2 padding;
        int4 intBorderColor;
    };
    SamplerMetadata samplerMetadata[1] : packoffset(c4);
};

float4 gl_texture2D(uint samplerIndex, float2 t, float bias)
{
    return textures2D[samplerIndex].SampleBias(samplers2D[samplerIndex], float2(t.x, t.y), bias);
}

#define GL_USES_FRAG_COORD
@@ PIXEL OUTPUT @@

PS_OUTPUT main(PS_INPUT input){
    float rhw = 1.0 / input.gl_FragCoord.w;
    gl_FragCoord.x = input.dx_Position.x - dx_FragCoordOffset.x;
    gl_FragCoord.y = input.dx_Position.y - dx_FragCoordOffset.y;
    gl_FragCoord.z = (input.gl_FragCoord.z * rhw) * dx_DepthFront.x + dx_DepthFront.y;
    gl_FragCoord.w = rhw;
    _vcolor_S0 = input.v0;
    _vTransformedCoords_6_S0 = input.v1.xy;

float4 _sk_FragCoord5641 = vec4_ctor(gl_FragCoord.x, (_u_skRTFlip.x + (_u_skRTFlip.y * gl_FragCoord.y)), gl_FragCoord.z, gl_FragCoord.w);
float4 _outputColor_S05642 = _vcolor_S0;
float4 __31_tmp_6_inColor5643 = _outputColor_S05642;
float4 __32_input5644 = __31_tmp_6_inColor5643;
float2 __35_tmp_3_coords5645 = _vTransformedCoords_6_S0;
float4 __36_t5646 = vec4_ctor((__35_tmp_3_coords5645.x + 9.9999997e-06), 1.0, 0.0, 0.0);
float4 __37_outColor5647 = {0, 0, 0, 0};
if ((__36_t5646.x < 0.0))
{
(__37_outColor5647 = _uleftBorderColor_S1_c0_c0);
}
else
{
if ((__36_t5646.x > 1.0))
{
(__37_outColor5647 = _urightBorderColor_S1_c0_c0);
}
else
{
float2 __39_tmp_1_coords5648 = vec2_ctor(__36_t5646.x, 0.0);
float __40_t5649 = __39_tmp_1_coords5648.x;
float4 __41_s5650 = {0, 0, 0, 0};
float4 __42_b5651 = {0, 0, 0, 0};
if ((__40_t5649 < _uthreshold_S1_c0_c0_c0))
{
(__41_s5650 = _uscale_S1_c0_c0_c0[0]);
(__42_b5651 = _ubias_S1_c0_c0_c