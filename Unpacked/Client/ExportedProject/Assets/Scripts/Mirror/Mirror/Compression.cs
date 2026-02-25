namespace Mirror;

[Token(Token = "0x2000091")]
public static class Compression
{
	[Token(Token = "0x40001E4")]
	private const float QuaternionMinRange = -0.707107; //Field offset: 0x0
	[Token(Token = "0x40001E5")]
	private const float QuaternionMaxRange = 0.707107; //Field offset: 0x0
	[Token(Token = "0x40001E6")]
	private const ushort TenBitsMax = 1023; //Field offset: 0x0

	[Address(RVA = "0x12874D0", Offset = "0x12866D0", Length = "0x1F4")]
	[CalledBy(Type = "Mirror.SyncDataReaderWriter", Member = "WriteSyncData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), "Mirror.SyncData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600049F")]
	public static uint CompressQuaternion(Quaternion q) { }

	[Address(RVA = "0x12876D0", Offset = "0x12868D0", Length = "0x15")]
	[CallerCount(Count = 4)]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A5")]
	public static void CompressVarInt(NetworkWriter writer, long i) { }

	[Address(RVA = "0x12876F0", Offset = "0x12868F0", Length = "0x3C0")]
	[CallerCount(Count = 40)]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004A4")]
	public static void CompressVarUInt(NetworkWriter writer, ulong value) { }

	[Address(RVA = "0x1287AC0", Offset = "0x1286CC0", Length = "0x1AB")]
	[CalledBy(Type = "Mirror.SyncDataReaderWriter", Member = "ReadSyncData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = "Mirror.SyncData")]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnDeserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180726960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004A1")]
	public static Quaternion DecompressQuaternion(uint data) { }

	[Address(RVA = "0x1287C70", Offset = "0x1286E70", Length = "0x1F")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Compression), Member = "DecompressVarUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(ulong))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A7")]
	public static long DecompressVarInt(NetworkReader reader) { }

	[Address(RVA = "0x1287C90", Offset = "0x1286E90", Length = "0x2F3")]
	[CallerCount(Count = 40)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBlittable", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadByte", ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60004A6")]
	public static ulong DecompressVarUInt(NetworkReader reader) { }

	[Address(RVA = "0x1287F90", Offset = "0x1287190", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600049E")]
	public static int LargestAbsoluteComponentIndex(Vector4 value, out float largestAbs, out Vector3 withoutLargest) { }

	[Address(RVA = "0x1288060", Offset = "0x1287260", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180726960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60004A0")]
	private static Quaternion QuaternionNormalizeSafe(Quaternion value) { }

	[Address(RVA = "0x1288100", Offset = "0x1287300", Length = "0x31")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600049C")]
	public static ushort ScaleFloatToUShort(float value, float minValue, float maxValue, ushort minTarget, ushort maxTarget) { }

	[Address(RVA = "0x12882E0", Offset = "0x12874E0", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x600049B")]
	public static Quaternion ScaleToFloat(Vector4Long value, float precision) { }

	[Address(RVA = "0x1288140", Offset = "0x1287340", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000499")]
	public static Quaternion ScaleToFloat(long x, long y, long z, long w, float precision) { }

	[Address(RVA = "0x12883A0", Offset = "0x12875A0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000498")]
	public static Vector3 ScaleToFloat(long x, long y, long z, float precision) { }

	[Address(RVA = "0x1288260", Offset = "0x1287460", Length = "0x71")]
	[CalledBy(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(long), typeof(long), typeof(float)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3Long), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4Long), typeof(float)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnDeserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000497")]
	public static float ScaleToFloat(long value, float precision) { }

	[Address(RVA = "0x12881D0", Offset = "0x12873D0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x600049A")]
	public static Vector3 ScaleToFloat(Vector3Long value, float precision) { }

	[Address(RVA = "0x1288420", Offset = "0x1287620", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000496")]
	public static bool ScaleToLong(Quaternion value, float precision, out Vector4Long quantized) { }

	[Address(RVA = "0x1288620", Offset = "0x1287820", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000495")]
	public static bool ScaleToLong(Vector3 value, float precision, out Vector3Long quantized) { }

	[Address(RVA = "0x1288780", Offset = "0x1287980", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000494")]
	public static bool ScaleToLong(Quaternion value, float precision, out long x, out long y, out long z, out long w) { }

	[Address(RVA = "0x1288700", Offset = "0x1287900", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000493")]
	public static bool ScaleToLong(Vector3 value, float precision, out long x, out long y, out long z) { }

	[Address(RVA = "0x1288520", Offset = "0x1287720", Length = "0xF3")]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "QuantizedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Int64&), typeof(Int64&), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(float), typeof(Int64&), typeof(Int64&), typeof(Int64&), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Vector3Long&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Compression), Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(float), typeof(Vector4Long&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000492")]
	public static bool ScaleToLong(float value, float precision, out long result) { }

	[Address(RVA = "0x1288820", Offset = "0x1287A20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600049D")]
	public static float ScaleUShortToFloat(ushort value, ushort minValue, ushort maxValue, float minTarget, float maxTarget) { }

	[Address(RVA = "0x1288860", Offset = "0x1287A60", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004A3")]
	public static int VarIntSize(long value) { }

	[Address(RVA = "0x1288900", Offset = "0x1287B00", Length = "0x8C")]
	[CalledBy(Type = typeof(Batcher), Member = "MessageHeaderSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Batcher), Member = "MaxMessageOverhead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Batcher), Member = "AddMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(double)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004A2")]
	public static int VarUIntSize(ulong value) { }

}

