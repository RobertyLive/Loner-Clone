form float3 _ucolorSpaceTranslate_S1_c0_c0 : register(c6);
static const uint _uTextureSampler_0_S1 = 0;
static const uint _uTextureSampler_1_S1 = 1;
static const uint _uTextureSampler_2_S1 = 2;
uniform Texture2D<float4> textures2D[3] : register(t0);
uniform SamplerState samplers2D[3] : register(s0);
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
static noperspective float2 _vTransformedCoords_5_S0 = {0, 0};
static noperspecti