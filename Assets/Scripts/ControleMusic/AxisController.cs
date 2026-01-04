so causes self-z-fighting on xbox 360, regardless of any ISOLATE usage
	FMaterialVertexParameters VertexParameters = GetMaterialVertexParameters(Input, VFIntermediates, WorldPos.xyz, float3x3(float3(0,0,0),float3(0,0,0),float3(0,0,0)));
#else
	float3x3 TangentBasis = VertexFactoryGetTangentBasis(Input, VFIntermediates);
	FMaterialVertexParameters VertexParameters = GetMaterialVertexParameters(Input, VFIntermediates, WorldPos.xyz, TangentBasis);
#endif
	// Isolate instructions used for world position offset on xbox 360, 
	// As these cause the optimizer to generate different position calcu