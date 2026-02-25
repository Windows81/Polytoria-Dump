namespace System;

[Token(Token = "0x2000126")]
public class Random
{
	[ThreadStatic]
	[Token(Token = "0x4000457")]
	private static Random t_threadRandom; //Field offset: 0x80000000
	[Token(Token = "0x4000458")]
	private static readonly Random s_globalRandom; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000454")]
	private int _inext; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000455")]
	private int _inextp; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000456")]
	private Int32[] _seedArray; //Field offset: 0x18

	[Address(RVA = "0x14BE200", Offset = "0x14BD400", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000950")]
	private static Random() { }

	[Address(RVA = "0x14BE290", Offset = "0x14BD490", Length = "0x53")]
	[CalledBy(Type = typeof(HashHelpers), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Path), Member = "GetTempFileName", ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<>c", Member = "<TestGame>b__79_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.MathModule", Member = "MoonSharpInit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Table", "MoonSharp.Interpreter.Table"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.LatencySimulation", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Random), Member = "GenerateSeed", ReturnType = typeof(int))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000944")]
	public Random() { }

	[Address(RVA = "0x14BE2F0", Offset = "0x14BD4F0", Length = "0x233")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.MathModule", Member = "randomseed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Dithering", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Security.SecureRandom", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Crypto.Prng.IRandomGenerator", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Security.SecureRandom", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Crypto.Prng.IRandomGenerator"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Security.SecureRandom", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolWorkQueueThreadLocals), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadPoolWorkQueue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Random), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Random), Member = "GenerateSeed", ReturnType = typeof(int))]
	[CalledBy(Type = "Mirror.BouncyCastle.Security.SecureRandom", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000945")]
	public Random(int Seed) { }

	[Address(RVA = "0x149E3B0", Offset = "0x149D5B0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000949")]
	private static int GenerateGlobalSeed() { }

	[Address(RVA = "0x14BDBE0", Offset = "0x14BCDE0", Length = "0x1CD")]
	[CalledBy(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Random), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000948")]
	private static int GenerateSeed() { }

	[Address(RVA = "0x14BDDB0", Offset = "0x14BCFB0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "InternalSample", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600094B")]
	private double GetSampleForLargeRange() { }

	[Address(RVA = "0x14BDE00", Offset = "0x14BD000", Length = "0x8F")]
	[CalledBy(Type = typeof(Random), Member = "Sample", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Random), Member = "Next", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Random), Member = "GetSampleForLargeRange", ReturnType = typeof(double))]
	[CalledBy(Type = typeof(Random), Member = "Next", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000947")]
	private int InternalSample() { }

	[Address(RVA = "0x14BE1D0", Offset = "0x14BD3D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "InternalSample", ReturnType = typeof(int))]
	[Token(Token = "0x600094A")]
	public override int Next() { }

	[Address(RVA = "0x14BDFD0", Offset = "0x14BD1D0", Length = "0x13E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "InternalSample", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600094C")]
	public override int Next(int minValue, int maxValue) { }

	[Address(RVA = "0x14BE110", Offset = "0x14BD310", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600094D")]
	public override int Next(int maxValue) { }

	[Address(RVA = "0x14BDE90", Offset = "0x14BD090", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600094F")]
	public override void NextBytes(Byte[] buffer) { }

	[Address(RVA = "0x14BDFB0", Offset = "0x14BD1B0", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600094E")]
	public override double NextDouble() { }

	[Address(RVA = "0x14BE1E0", Offset = "0x14BD3E0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "InternalSample", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000946")]
	protected override double Sample() { }

}

