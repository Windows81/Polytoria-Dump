namespace UnityEngine;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Matrix4x4f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20000FB")]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
{
	[Token(Token = "0x40004A6")]
	private static readonly Matrix4x4 zeroMatrix; //Field offset: 0x0
	[Token(Token = "0x40004A7")]
	private static readonly Matrix4x4 identityMatrix; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[NativeName("m_Data[0]")]
	[Token(Token = "0x4000496")]
	public float m00; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("m_Data[1]")]
	[Token(Token = "0x4000497")]
	public float m10; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_Data[2]")]
	[Token(Token = "0x4000498")]
	public float m20; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("m_Data[3]")]
	[Token(Token = "0x4000499")]
	public float m30; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[NativeName("m_Data[4]")]
	[Token(Token = "0x400049A")]
	public float m01; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[NativeName("m_Data[5]")]
	[Token(Token = "0x400049B")]
	public float m11; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[NativeName("m_Data[6]")]
	[Token(Token = "0x400049C")]
	public float m21; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[NativeName("m_Data[7]")]
	[Token(Token = "0x400049D")]
	public float m31; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[NativeName("m_Data[8]")]
	[Token(Token = "0x400049E")]
	public float m02; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[NativeName("m_Data[9]")]
	[Token(Token = "0x400049F")]
	public float m12; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[NativeName("m_Data[10]")]
	[Token(Token = "0x40004A0")]
	public float m22; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[NativeName("m_Data[11]")]
	[Token(Token = "0x40004A1")]
	public float m32; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[NativeName("m_Data[12]")]
	[Token(Token = "0x40004A2")]
	public float m03; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[NativeName("m_Data[13]")]
	[Token(Token = "0x40004A3")]
	public float m13; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[NativeName("m_Data[14]")]
	[Token(Token = "0x40004A4")]
	public float m23; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[NativeName("m_Data[15]")]
	[Token(Token = "0x40004A5")]
	public float m33; //Field offset: 0x3C

	[Token(Token = "0x1700013F")]
	public FrustumPlanes decomposeProjection
	{
		[Address(RVA = "0x19496C0", Offset = "0x19488C0", Length = "0x70")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GenerateJitteredProjectionMatrixFromOriginal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(Matrix4x4), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000720")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000144")]
	public static Matrix4x4 identity
	{
		[Address(RVA = "0x1949730", Offset = "0x1948930", Length = "0x5B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600073C")]
		 get { } //Length: 91
	}

	[Token(Token = "0x17000140")]
	public Matrix4x4 inverse
	{
		[Address(RVA = "0x1949790", Offset = "0x1948990", Length = "0xAD")]
		[CalledBy(Type = "RLD.PrismMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion), "RLD.PrismEpsilon"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "AddLink", ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "GetLocalPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.ObjectPositionCalculator", Member = "CalculateRootPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "RLD.XZGridCell", Member = "FromPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), "RLD.IXZGrid"}, ReturnType = "RLD.XZGridCell")]
		[CalledBy(Type = "RLD.MeshTree", Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = "RLD.MeshRayHit")]
		[CalledBy(Type = "RLD.PyramidMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), "RLD.PyramidEpsilon"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
		[CalledBy(Type = "RLD.ConeMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), "RLD.ConeEpsilon"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.BoxMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), "RLD.BoxEpsilon"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.OBB", Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.OBB"}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.AABB", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.RayEx", Member = "InverseTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(Ray))]
		[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "GetRelativeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderEvents", Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderData", "UnityEngine.UIElements.UIR.RenderTreeManager", "UnityEngine.UIElements.UIR.UIRenderDevice"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.ConeMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), "RLD.ConeEpsilon"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000724")]
		 get { } //Length: 173
	}

	[Token(Token = "0x17000142")]
	public float Item
	{
		[Address(RVA = "0x19496B0", Offset = "0x19488B0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[Token(Token = "0x600072B")]
		 get { } //Length: 14
		[Address(RVA = "0x194A060", Offset = "0x1949260", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[Token(Token = "0x600072C")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000143")]
	public float Item
	{
		[Address(RVA = "0x1949550", Offset = "0x1948750", Length = "0x118")]
		[CalledBy(Type = "LTRect", Member = "resetForRotation", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleJSON.JSONNode", Member = "WriteMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = "SimpleJSON.JSONNode")]
		[CalledBy(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CalculateTanHalfFovHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600072D")]
		 get { } //Length: 280
		[Address(RVA = "0x1949F00", Offset = "0x1949100", Length = "0x118")]
		[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "RotationMatrixFromRightUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = "SimpleJSON.JSONNode", Member = "ReadMatrix", ReturnType = typeof(Matrix4x4))]
		[CalledBy(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Matrix4x4), Member = "SetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600072E")]
		 set { } //Length: 280
	}

	[Token(Token = "0x1700013E")]
	public Vector3 lossyScale
	{
		[Address(RVA = "0x1949840", Offset = "0x1948A40", Length = "0x69")]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "CreateCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), typeof(Single&)}, ReturnType = typeof(Camera))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600071F")]
		 get { } //Length: 105
	}

	[Token(Token = "0x1700013D")]
	public Quaternion rotation
	{
		[Address(RVA = "0x19498B0", Offset = "0x1948AB0", Length = "0x5A")]
		[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600071E")]
		 get { } //Length: 90
	}

	[Token(Token = "0x17000141")]
	public Matrix4x4 transpose
	{
		[Address(RVA = "0x1949910", Offset = "0x1948B10", Length = "0xAD")]
		[CalledBy(Type = "RLD.MeshTree", Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = "RLD.MeshRayHit")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000726")]
		 get { } //Length: 173
	}

	[Address(RVA = "0x19493C0", Offset = "0x19485C0", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600073F")]
	private static Matrix4x4() { }

	[Address(RVA = "0x19494E0", Offset = "0x19486E0", Length = "0x6D")]
	[CalledBy(Type = "UnityEngine.UIElements.FilterFunctionDefinitionUtils", Member = "PrepareBuiltinColorEffectMaterialPropertyBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialPropertyBlock), "UnityEngine.UIElements.FilterFunction"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x600072A")]
	public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	[Address(RVA = "0x1947A80", Offset = "0x1946C80", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600071D")]
	private FrustumPlanes DecomposeProjection() { }

	[Address(RVA = "0x1947A30", Offset = "0x1946C30", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000742")]
	private static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret) { }

	[Address(RVA = "0x1947B90", Offset = "0x1946D90", Length = "0x105")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000731")]
	public override bool Equals(Matrix4x4 other) { }

	[Address(RVA = "0x1947AE0", Offset = "0x1946CE0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18061FB10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000730")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x1947D20", Offset = "0x1946F20", Length = "0x12D")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GenerateJitteredProjectionMatrixFromOriginal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(Matrix4x4), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000729")]
	public static Matrix4x4 Frustum(FrustumPlanes fp) { }

	[Address(RVA = "0x1947E50", Offset = "0x1947050", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = True)]
	[Token(Token = "0x6000728")]
	public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[Address(RVA = "0x1947CA0", Offset = "0x1946EA0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000748")]
	private static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	[Address(RVA = "0x19496C0", Offset = "0x19488C0", Length = "0x70")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GenerateJitteredProjectionMatrixFromOriginal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext", typeof(Matrix4x4), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000720")]
	public FrustumPlanes get_decomposeProjection() { }

	[Address(RVA = "0x1949730", Offset = "0x1948930", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600073C")]
	public static Matrix4x4 get_identity() { }

	[Address(RVA = "0x1949790", Offset = "0x1948990", Length = "0xAD")]
	[CalledBy(Type = "RLD.ConeMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), "RLD.ConeEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderEvents", Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderData", "UnityEngine.UIElements.UIR.RenderTreeManager", "UnityEngine.UIElements.UIR.UIRenderDevice"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "GetRelativeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "RLD.RayEx", Member = "InverseTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "RLD.AABB", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.OBB", Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.OBB"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.ConeMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), "RLD.ConeEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.BoxMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), "RLD.BoxEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.PyramidMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), "RLD.PyramidEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.MeshTree", Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = "RLD.MeshRayHit")]
	[CalledBy(Type = "RLD.XZGridCell", Member = "FromPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), "RLD.IXZGrid"}, ReturnType = "RLD.XZGridCell")]
	[CalledBy(Type = "RLD.ObjectPositionCalculator", Member = "CalculateRootPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "GetLocalPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "AddLink", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.PrismMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion), "RLD.PrismEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000724")]
	public Matrix4x4 get_inverse() { }

	[Address(RVA = "0x19496B0", Offset = "0x19488B0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x600072B")]
	public float get_Item(int row, int column) { }

	[Address(RVA = "0x1949550", Offset = "0x1948750", Length = "0x118")]
	[CalledBy(Type = "LTRect", Member = "resetForRotation", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleJSON.JSONNode", Member = "WriteMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = "SimpleJSON.JSONNode")]
	[CalledBy(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "CalculateTanHalfFovHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.MultiScaleVO", Member = "GenerateAOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), "System.Nullable`1<RenderTargetIdentifier>", typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600072D")]
	public float get_Item(int index) { }

	[Address(RVA = "0x1949840", Offset = "0x1948A40", Length = "0x69")]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "CreateCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), typeof(Single&)}, ReturnType = typeof(Camera))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071F")]
	public Vector3 get_lossyScale() { }

	[Address(RVA = "0x19498B0", Offset = "0x1948AB0", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071E")]
	public Quaternion get_rotation() { }

	[Address(RVA = "0x1949910", Offset = "0x1948B10", Length = "0xAD")]
	[CalledBy(Type = "RLD.MeshTree", Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = "RLD.MeshRayHit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000726")]
	public Matrix4x4 get_transpose() { }

	[Address(RVA = "0x1947F00", Offset = "0x1947100", Length = "0xC2")]
	[CalledBy(Type = "System.Collections.Generic.GenericEqualityComparer`1", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "GetTranslation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "GetScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "GetNormalizedAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(int)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "GetNormalizedAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = "UnityEngine.Vector3[]")]
	[CalledBy(Type = "RLD.BoxMath", Member = "TransformBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Matrix4x4), typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000733")]
	public Vector4 GetColumn(int index) { }

	[Address(RVA = "0x1947FD0", Offset = "0x19471D0", Length = "0x1AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x600072F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x19481D0", Offset = "0x19473D0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600071C")]
	private Vector3 GetLossyScale() { }

	[Address(RVA = "0x1948180", Offset = "0x1947380", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000741")]
	private static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	[Address(RVA = "0x1948220", Offset = "0x1947420", Length = "0x1F")]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "SetTransform", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000735")]
	public Vector3 GetPosition() { }

	[Address(RVA = "0x1948290", Offset = "0x1947490", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600071B")]
	private Quaternion GetRotation() { }

	[Address(RVA = "0x1948240", Offset = "0x1947440", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000740")]
	private static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	[Address(RVA = "0x19482E0", Offset = "0x19474E0", Length = "0xEF")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = "SetTransformValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.BMPAlloc", typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.UIRVEShaderInfoAllocator", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000734")]
	public Vector4 GetRow(int index) { }

	[Address(RVA = "0x19484C0", Offset = "0x19476C0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	[Token(Token = "0x6000723")]
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	[Address(RVA = "0x1948470", Offset = "0x1947670", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000745")]
	private static void Inverse_Injected(in Matrix4x4 m, out Matrix4x4 ret) { }

	[Address(RVA = "0x1948420", Offset = "0x1947620", Length = "0x42")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_worldTransformInverse", ReturnType = typeof(Matrix4x4&))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "UpdateWorldTransformInverse", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = True)]
	[Token(Token = "0x6000722")]
	public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	[Address(RVA = "0x19483D0", Offset = "0x19475D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000744")]
	private static bool Inverse3DAffine_Injected(in Matrix4x4 input, ref Matrix4x4 result) { }

	[Address(RVA = "0x19485C0", Offset = "0x19477C0", Length = "0xF1")]
	[CalledBy(Type = "RLD.ConeMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), "RLD.ConeEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.XZGridCell", Member = "FromPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), "RLD.IXZGrid"}, ReturnType = "RLD.XZGridCell")]
	[CalledBy(Type = "RLD.MeshVertexChunk", Member = "GetWorldVertClosestToScreenPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.MeshTree", Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = "RLD.MeshRayHit")]
	[CalledBy(Type = "RLD.PyramidMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), "RLD.PyramidEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.PrismMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion), "RLD.PrismEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.PrismMath", Member = "CalcTriangPrismCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "RLD.ConeMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), "RLD.ConeEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.BoxMath", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), "RLD.BoxEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.BoxMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Quaternion), "RLD.BoxEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.BoxMath", Member = "TransformBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Matrix4x4), typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.AABB", Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RayEx", Member = "InverseTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "TransformPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), "System.Collections.Generic.List`1<Vector3>"}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
	[CalledBy(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 24)]
	[Token(Token = "0x6000738")]
	public Vector3 MultiplyPoint(Vector3 point) { }

	[Address(RVA = "0x1948520", Offset = "0x1947720", Length = "0x96")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.VisualElement", typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "GetWorldPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "InternalGetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3[]", typeof(Matrix4x4&)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "TransformRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "HaveTransformsChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "WorldToLocal3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "ComputeAAAlignedBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Matrix4x4)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = "UnityEngine.UIElements.WorldSpaceInput+PickResult")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput+PickResult", Member = "ComputeCollisionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "GetLocalPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshLink", Member = "AddLink", ReturnType = typeof(void))]
	[CallerCount(Count = 44)]
	[Token(Token = "0x6000739")]
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	[Address(RVA = "0x19486C0", Offset = "0x19478C0", Length = "0x87")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput+PickResult", Member = "ComputeCollisionData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "PickDocument3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(float), typeof(int)}, ReturnType = "UnityEngine.UIElements.WorldSpaceInput+PickResult")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "LocalToWorld", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "WorldToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "ChangeCoordinatesTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.VisualElement", typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "IntersectWorldRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Ray), typeof(Single&), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElementExtensions", Member = "TransformRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Ray)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "RLD.RayEx", Member = "InverseTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "RLD.ConeMath", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), "RLD.ConeEpsilon"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.MeshTree", Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = "RLD.MeshRayHit")]
	[CalledBy(Type = "RLD.ObjectPositionCalculator", Member = "CalculateRootPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "GetWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 17)]
	[Token(Token = "0x600073A")]
	public Vector3 MultiplyVector(Vector3 vector) { }

	[Address(RVA = "0x19499C0", Offset = "0x1948BC0", Length = "0x53B")]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "GetCameraWorldPlanes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = "UnityEngine.Plane[]")]
	[CalledBy(Type = "UnityEngine.GUIUtility", Member = "RotateAroundPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectBoundsInstantiator", Member = "AddPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(string), "GLTFast.MeshResult", "System.UInt32[]", "System.Nullable`1<UInt32>", "System.Single[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.ObjectPositionCalculator", Member = "CalculateRootPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "GetRelativeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "RLD.AABB"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Unity.AI.Navigation.NavMeshSurface", Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<NavMeshBuildSource>"}, ReturnType = typeof(Bounds))]
	[CalledBy(Type = "RLD.CameraViewVolume", Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderEvents", Member = "NudgeVerticesToNewSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderData", "UnityEngine.UIElements.UIR.RenderTreeManager", "UnityEngine.UIElements.UIR.UIRenderDevice"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "GetCurrentTransformAndClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IMGUIContainer", "UnityEngine.Event", typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event", typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoIMGUIRepaint", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIDocument", Member = "ComputeTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Matrix4x4&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "FillCommonParameters", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "WorldToMask", ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 23)]
	[Token(Token = "0x6000732")]
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	[Address(RVA = "0x19487D0", Offset = "0x19479D0", Length = "0xA5")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddCameraOrthographic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(float), "System.Nullable`1<Single>", typeof(float), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = True)]
	[Token(Token = "0x6000727")]
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	[Address(RVA = "0x1948750", Offset = "0x1947950", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000747")]
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	[Address(RVA = "0x1948880", Offset = "0x1947A80", Length = "0x1A9")]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x600073B")]
	public static Matrix4x4 Rotate(Quaternion q) { }

	[Address(RVA = "0x1949F00", Offset = "0x1949100", Length = "0x118")]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "RotationMatrixFromRightUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "SimpleJSON.JSONNode", Member = "ReadMatrix", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Matrix4x4), Member = "SetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Matrix4x4), Member = "SetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.RuntimeUtilities", Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600072E")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x194A060", Offset = "0x1949260", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600072C")]
	public void set_Item(int row, int column, float value) { }

	[Address(RVA = "0x1948A30", Offset = "0x1947C30", Length = "0x7F")]
	[CalledBy(Type = "RLD.Matrix4x4Ex", Member = "Translation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000736")]
	public void SetColumn(int index, Vector4 column) { }

	[Address(RVA = "0x1948AB0", Offset = "0x1947CB0", Length = "0x6C")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.ScreenSpaceReflectionsRenderer", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.PostProcessRenderContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000737")]
	public void SetRow(int index, Vector4 row) { }

	[Address(RVA = "0x1948C20", Offset = "0x1947E20", Length = "0x6E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600073E")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x1948C10", Offset = "0x1947E10", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E2A170")]
	[Token(Token = "0x600073D")]
	public virtual string ToString() { }

	[Address(RVA = "0x1949360", Offset = "0x1948560", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("MatrixScripting::Transpose", IsThreadSafe = True)]
	[Token(Token = "0x6000725")]
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	[Address(RVA = "0x1949310", Offset = "0x1948510", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000746")]
	private static void Transpose_Injected(in Matrix4x4 m, out Matrix4x4 ret) { }

	[Address(RVA = "0x1948B90", Offset = "0x1947D90", Length = "0x77")]
	[CallerCount(Count = 88)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	[Token(Token = "0x6000721")]
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[Address(RVA = "0x1948B20", Offset = "0x1947D20", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000743")]
	private static void TRS_Injected(in Vector3 pos, in Quaternion q, in Vector3 s, out Matrix4x4 ret) { }

}

