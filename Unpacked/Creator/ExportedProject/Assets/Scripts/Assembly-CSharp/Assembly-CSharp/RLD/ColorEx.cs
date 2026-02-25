namespace RLD;

[Extension]
[Token(Token = "0x200015F")]
public static class ColorEx
{

	[Address(RVA = "0x53EAD0", Offset = "0x53DCD0", Length = "0x5B")]
	[CalledBy(Type = typeof(RTSystemValues), Member = "get_XAxisColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(RTSystemValues), Member = "get_YAxisColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(RTSystemValues), Member = "get_ZAxisColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(RTSystemValues), Member = "get_GridLineColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(RTSystemValues), Member = "get_HoveredAxisColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(RTSystemValues), Member = "get_CenterAxisColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(RTSystemValues), Member = "get_CameraBkGradientFirstColor", ReturnType = typeof(Color))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XZGridLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGrabLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSelectionLookAndFeel), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Token(Token = "0x6000FD6")]
	public static Color FromByteValues(byte r, byte g, byte b, byte a) { }

	[Address(RVA = "0x53EB30", Offset = "0x53DD30", Length = "0x80")]
	[CalledBy(Type = typeof(PyramidMesh), Member = "CreatePyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(TorusMesh), Member = "CreateCylindricalTorus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(SphereMesh), Member = "CreateSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(QuadMesh), Member = "CreateWireQuadXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(QuadMesh), Member = "CreateQuadXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(QuadMesh), Member = "CreateQuadXZ", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(PyramidMesh), Member = "CreateWirePyramid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(PrismMesh), Member = "CreateWireTriangularPrism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(PrismMesh), Member = "CreateTriangularPrism", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(LineMesh), Member = "CreateLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(LineMesh), Member = "CreateCoordSystemAxesLines", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(CylinderMesh), Member = "CreateCylinder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(int), typeof(int), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(CircleMesh), Member = "CreateWireCircleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(CircleMesh), Member = "CreateCircleXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(BoxMesh), Member = "CreateWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(BoxMesh), Member = "CreateBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(TorusMesh), Member = "CreateTorus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000FD7")]
	public static Color[] GetFilledColorArray(int arrayLength, Color fillValue) { }

	[Address(RVA = "0x53EBC0", Offset = "0x53DDC0", Length = "0x19")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000FD8")]
	public static Color KeepAllButAlpha(Color color, float newAlpha) { }

}

