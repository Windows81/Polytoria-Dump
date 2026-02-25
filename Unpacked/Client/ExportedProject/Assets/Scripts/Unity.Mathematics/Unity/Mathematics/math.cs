namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000003")]
public static class math
{
	[Token(Token = "0x2000004")]
	public struct LongDoubleUnion
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000001")]
		public long longValue; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000002")]
		public double doubleValue; //Field offset: 0x0

	}


	[Address(RVA = "0x1826CA0", Offset = "0x1825EA0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000018")]
	public static float abs(float x) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	public static float4 asfloat(uint4 x) { }

	[Address(RVA = "0x1826CB0", Offset = "0x1825EB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000F")]
	public static float asfloat(uint x) { }

	[Address(RVA = "0x140B7B0", Offset = "0x140A9B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public static int asint(float x) { }

	[Address(RVA = "0x702130", Offset = "0x701330", Length = "0xA")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public static uint4 asuint(float4 x) { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public static uint3 asuint(float3 x) { }

	[Address(RVA = "0x140B7B0", Offset = "0x140A9B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public static uint asuint(float x) { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public static uint3 asuint(int3 x) { }

	[Address(RVA = "0x1826CC0", Offset = "0x1825EC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600000C")]
	public static uint2 asuint(float2 x) { }

	[Address(RVA = "0x1826CD0", Offset = "0x1825ED0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028BE30")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001B")]
	public static float cos(float x) { }

	[Address(RVA = "0x1826D30", Offset = "0x1825F30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000022")]
	public static float3 cross(float3 x, float3 y) { }

	[Address(RVA = "0x1826DC0", Offset = "0x1825FC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000026")]
	public static uint csum(uint3 x) { }

	[Address(RVA = "0x1826DA0", Offset = "0x1825FA0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000025")]
	public static uint csum(uint2 x) { }

	[Address(RVA = "0x1826DB0", Offset = "0x1825FB0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000027")]
	public static uint csum(uint4 x) { }

	[Address(RVA = "0x1826E10", Offset = "0x1826010", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000028")]
	public static float dot(quaternion a, quaternion b) { }

	[Address(RVA = "0x1826DD0", Offset = "0x1825FD0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600001A")]
	public static float dot(float4 x, float4 y) { }

	[Address(RVA = "0x1826E60", Offset = "0x1826060", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000019")]
	public static float dot(float3 x, float3 y) { }

	[Address(RVA = "0x40E010", Offset = "0x40D210", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public static float4 float4(float x, float y, float z, float w) { }

	[Address(RVA = "0x1825460", Offset = "0x1824660", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000029")]
	public static uint hash(quaternion q) { }

	[Address(RVA = "0x1826F90", Offset = "0x1826190", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600002B")]
	public static uint hash(uint2 v) { }

	[Address(RVA = "0x1826F40", Offset = "0x1826140", Length = "0x41")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public static uint hash(uint3 v) { }

	[Address(RVA = "0x1826E90", Offset = "0x1826090", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000002")]
	public static uint hash(float2 v) { }

	[Address(RVA = "0x1826EF0", Offset = "0x18260F0", Length = "0x48")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	public static uint hash(uint4 v) { }

	[Address(RVA = "0x18244A0", Offset = "0x18236A0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public static uint hash(float3 v) { }

	[Address(RVA = "0x1826FE0", Offset = "0x18261E0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000004")]
	public static uint hash(float3x3 v) { }

	[Address(RVA = "0x1825460", Offset = "0x1824660", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public static uint hash(float4 v) { }

	[Address(RVA = "0x1823710", Offset = "0x1822910", Length = "0x9F4")]
	[CalledBy(Type = typeof(float4x4), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000007")]
	public static uint hash(float4x4 v) { }

	[Address(RVA = "0x1826AF0", Offset = "0x1825CF0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public static uint hash(int3 v) { }

	[Address(RVA = "0x18270A0", Offset = "0x18262A0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181072800")]
	[Token(Token = "0x6000021")]
	public static float length(float3 x) { }

	[Address(RVA = "0x18270E0", Offset = "0x18262E0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000023")]
	public static int lzcnt(int x) { }

	[Address(RVA = "0x18270E0", Offset = "0x18262E0", Length = "0x43")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000024")]
	public static int lzcnt(uint x) { }

	[Address(RVA = "0x1827270", Offset = "0x1826470", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000013")]
	public static int max(int x, int y) { }

	[Address(RVA = "0x1827130", Offset = "0x1826330", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000017")]
	public static float4 max(float4 x, float4 y) { }

	[Address(RVA = "0x1827250", Offset = "0x1826450", Length = "0x18")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000014")]
	public static float max(float x, float y) { }

	[Address(RVA = "0x1827280", Offset = "0x1826480", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000015")]
	public static float2 max(float2 x, float2 y) { }

	[Address(RVA = "0x18271D0", Offset = "0x18263D0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000016")]
	public static float3 max(float3 x, float3 y) { }

	[Address(RVA = "0x18272F0", Offset = "0x18264F0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000012")]
	public static long min(long x, long y) { }

	[Address(RVA = "0x18272E0", Offset = "0x18264E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000011")]
	public static int min(int x, int y) { }

	[Address(RVA = "0x18273E0", Offset = "0x18265E0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181072800")]
	[Token(Token = "0x600001F")]
	public static float3 normalize(float3 x) { }

	[Address(RVA = "0x1827300", Offset = "0x1826500", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181072800")]
	[Token(Token = "0x6000020")]
	public static float4 normalize(float4 x) { }

	[Address(RVA = "0x10727E0", Offset = "0x10719E0", Length = "0x95")]
	[CalledBy(Type = "GLTFast.Jobs.ConvertTangentsInt16ToFloatInterleavedNormalizedJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Jobs.ConvertTangentsInt8ToFloatInterleavedNormalizedJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Jobs.ConvertNormalsInt16ToFloatInterleavedNormalizedJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.Jobs.ConvertNormalsInt8ToFloatInterleavedNormalizedJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181072800")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001E")]
	public static float rsqrt(float x) { }

	[Address(RVA = "0x1827470", Offset = "0x1826670", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028CBC0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001C")]
	public static float sin(float x) { }

	[Address(RVA = "0x18274D0", Offset = "0x18266D0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001D")]
	public static float sqrt(float x) { }

	[Address(RVA = "0x1827550", Offset = "0x1826750", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600002A")]
	public static uint2 uint2(uint x, uint y) { }

	[Address(RVA = "0x1827560", Offset = "0x1826760", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600002C")]
	public static uint3 uint3(uint x, uint y, uint z) { }

	[Address(RVA = "0x1827590", Offset = "0x1826790", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600002F")]
	public static uint4 uint4(int v) { }

	[Address(RVA = "0x1827570", Offset = "0x1826770", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600002E")]
	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

}

