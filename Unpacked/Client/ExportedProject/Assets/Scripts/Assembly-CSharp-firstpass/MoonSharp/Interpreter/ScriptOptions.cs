namespace MoonSharp.Interpreter;

[Token(Token = "0x200007F")]
public class ScriptOptions
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000277")]
	private IScriptLoader <ScriptLoader>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000278")]
	private Action<String> <DebugPrint>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000279")]
	private Func<String, String> <DebugInput>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400027A")]
	private bool <UseLuaErrorLocations>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400027B")]
	private ColonOperatorBehaviour <ColonOperatorClrCallbackBehaviour>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400027C")]
	private Stream <Stdin>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400027D")]
	private Stream <Stdout>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400027E")]
	private Stream <Stderr>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400027F")]
	private int <TailCallOptimizationThreshold>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000280")]
	private bool <CheckThreadAccess>k__BackingField; //Field offset: 0x4C

	[Token(Token = "0x170000EF")]
	public bool CheckThreadAccess
	{
		[Address(RVA = "0x3095E0", Offset = "0x3087E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CA")]
		 get { } //Length: 5
		[Address(RVA = "0x309640", Offset = "0x308840", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006CB")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000EA")]
	public ColonOperatorBehaviour ColonOperatorClrCallbackBehaviour
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C0")]
		 get { } //Length: 4
		[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000E8")]
	public Func<String, String> DebugInput
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BC")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000E7")]
	public Action<String> DebugPrint
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BA")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000E6")]
	public IScriptLoader ScriptLoader
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B8")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006B9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000ED")]
	public Stream Stderr
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C6")]
		 get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C7")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000EB")]
	public Stream Stdin
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C2")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000EC")]
	public Stream Stdout
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C4")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000EE")]
	public int TailCallOptimizationThreshold
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C8")]
		 get { } //Length: 4
		[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006C9")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170000E9")]
	public bool UseLuaErrorLocations
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BE")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60006BF")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B6")]
	internal ScriptOptions() { }

	[Address(RVA = "0x309530", Offset = "0x308730", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006B7")]
	internal ScriptOptions(ScriptOptions defaults) { }

	[Address(RVA = "0x3095E0", Offset = "0x3087E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CA")]
	public bool get_CheckThreadAccess() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C0")]
	public ColonOperatorBehaviour get_ColonOperatorClrCallbackBehaviour() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BC")]
	public Func<String, String> get_DebugInput() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BA")]
	public Action<String> get_DebugPrint() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B8")]
	public IScriptLoader get_ScriptLoader() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C6")]
	public Stream get_Stderr() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C2")]
	public Stream get_Stdin() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C4")]
	public Stream get_Stdout() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C8")]
	public int get_TailCallOptimizationThreshold() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BE")]
	public bool get_UseLuaErrorLocations() { }

	[Address(RVA = "0x309640", Offset = "0x308840", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006CB")]
	public void set_CheckThreadAccess(bool value) { }

	[Address(RVA = "0x309650", Offset = "0x308850", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C1")]
	public void set_ColonOperatorClrCallbackBehaviour(ColonOperatorBehaviour value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BD")]
	public void set_DebugInput(Func<String, String> value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BB")]
	public void set_DebugPrint(Action<String> value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B9")]
	public void set_ScriptLoader(IScriptLoader value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C7")]
	public void set_Stderr(Stream value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C3")]
	public void set_Stdin(Stream value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C5")]
	public void set_Stdout(Stream value) { }

	[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006C9")]
	public void set_TailCallOptimizationThreshold(int value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60006BF")]
	public void set_UseLuaErrorLocations(bool value) { }

}

