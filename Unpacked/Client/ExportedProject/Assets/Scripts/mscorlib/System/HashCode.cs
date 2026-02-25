namespace System;

[Token(Token = "0x20000F2")]
public struct HashCode
{
	[Token(Token = "0x400040E")]
	private static readonly uint s_seed; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400040F")]
	private uint _v1; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000410")]
	private uint _v2; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000411")]
	private uint _v3; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000412")]
	private uint _v4; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000413")]
	private uint _queue1; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000414")]
	private uint _queue2; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000415")]
	private uint _queue3; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000416")]
	private uint _length; //Field offset: 0x1C

	[Address(RVA = "0x149E960", Offset = "0x149DB60", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600078B")]
	private static HashCode() { }

	[Address(RVA = "0x149E1C0", Offset = "0x149D3C0", Length = "0x19D")]
	[CalledBy(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1806D2200")]
	[Token(Token = "0x6000787")]
	private void Add(int value) { }

	[Address(RVA = "0x6B6160", Offset = "0x6B5360", Length = "0x8C")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000786")]
	public void Add(T value) { }

	[Address(RVA = "0x6D4AE0", Offset = "0x6D3CE0", Length = "0x14B")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleValueHandle", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.IntegerTime.RationalTime+TicksPerSecond", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.PhysicsScene", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyFlattenedNode", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "Unity.Hierarchy.HierarchyNode", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "MixEmptyState", ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077B")]
	public static int Combine(T1 value1, T2 value2) { }

	[Address(RVA = "0x6D4930", Offset = "0x6D3B30", Length = "0x1AA")]
	[CalledBy(Type = "GLTFast.Schema.TextureBase", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "MixEmptyState", ReturnType = typeof(uint))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077C")]
	public static int Combine(T1 value1, T2 value2, T3 value3) { }

	[Address(RVA = "0x6D4C30", Offset = "0x6D3E30", Length = "0x2A3")]
	[CalledBy(Type = "Mirror.Vector4Long", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1806D20F0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077D")]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4) { }

	[Address(RVA = "0x6D5370", Offset = "0x6D4570", Length = "0x3A5")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.RenderedText", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1806D20F0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077E")]
	public static int Combine(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) { }

	[Address(RVA = "0x149E360", Offset = "0x149D560", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes.", True)]
	[Token(Token = "0x600078A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x149E3B0", Offset = "0x149D5B0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600077A")]
	private static uint GenerateGlobalSeed() { }

	[Address(RVA = "0x149E3E0", Offset = "0x149D5E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Obsolete("HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.", True)]
	[Token(Token = "0x6000789")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x149E430", Offset = "0x149D630", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000780")]
	private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4) { }

	[Address(RVA = "0x149E500", Offset = "0x149D700", Length = "0x52")]
	[CalledBy(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000784")]
	private static uint MixEmptyState() { }

	[Address(RVA = "0x149E560", Offset = "0x149D760", Length = "0x22")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000785")]
	private static uint MixFinal(uint hash) { }

	[Address(RVA = "0x149E590", Offset = "0x149D790", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000783")]
	private static uint MixState(uint v1, uint v2, uint v3, uint v4) { }

	[Address(RVA = "0x149E630", Offset = "0x149D830", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000782")]
	private static uint QueueRound(uint hash, uint queuedValue) { }

	[Address(RVA = "0x10BD150", Offset = "0x10BC350", Length = "0x19")]
	[CallerCount(Count = 115)]
	[DeduplicatedMethod]
	[Token(Token = "0x600077F")]
	private static uint Rol(uint value, int count) { }

	[Address(RVA = "0x149E6A0", Offset = "0x149D8A0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000781")]
	private static uint Round(uint hash, uint input) { }

	[Address(RVA = "0x149E710", Offset = "0x149D910", Length = "0x250")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1806D2190")]
	[Token(Token = "0x6000788")]
	public int ToHashCode() { }

}

