namespace Polytoria.Controllers;

[Token(Token = "0x200042B")]
public class CreatorController : NetworkBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200042E")]
	private sealed class <>c
	{
		[Token(Token = "0x40011EB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40011EC")]
		public static Func<Instance, Boolean> <>9__57_0; //Field offset: 0x8
		[Token(Token = "0x40011ED")]
		public static Func<String, Char> <>9__79_0; //Field offset: 0x10
		[Token(Token = "0x40011EE")]
		public static Func<String, Char> <>9__82_0; //Field offset: 0x18
		[Token(Token = "0x40011EF")]
		public static Func<Instance, GameObject> <>9__96_0; //Field offset: 0x20

		[Address(RVA = "0x4E83F0", Offset = "0x4E75F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002C9C")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C9D")]
		public <>c() { }

		[Address(RVA = "0x4E77F0", Offset = "0x4E69F0", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002C9E")]
		internal bool <DoExportModel>b__57_0(Instance i) { }

		[Address(RVA = "0x4E7920", Offset = "0x4E6B20", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002CA0")]
		internal char <RandomString>b__82_0(string s) { }

		[Address(RVA = "0x4E79B0", Offset = "0x4E6BB0", Length = "0x82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002C9F")]
		internal char <TestGame>b__79_0(string s) { }

		[Address(RVA = "0x4E7A40", Offset = "0x4E6C40", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002CA1")]
		internal GameObject <Update>b__96_0(Instance i) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200042F")]
	private sealed class <>c__DisplayClass46_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011F0")]
		public string mat; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011F1")]
		public CreatorController <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CA2")]
		public <>c__DisplayClass46_0() { }

		[Address(RVA = "0x4E8020", Offset = "0x4E7220", Length = "0x111")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6002CA3")]
		internal void <Start>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000430")]
	private sealed class <>c__DisplayClass53_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011F2")]
		public int lowestLevel; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CA4")]
		public <>c__DisplayClass53_0() { }

		[Address(RVA = "0x4CF3D0", Offset = "0x4CE5D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Instance), Member = "get_DescendantLevel", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CA5")]
		internal bool <GroupSelection>b__0(Instance i) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000431")]
	private sealed class <>c__DisplayClass54_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011F3")]
		public int lowestLevel; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CA6")]
		public <>c__DisplayClass54_0() { }

		[Address(RVA = "0x4CF3D0", Offset = "0x4CE5D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Instance), Member = "get_DescendantLevel", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CA7")]
		internal bool <UngroupSelection>b__0(Instance i) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000432")]
	private sealed class <>c__DisplayClass68_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011F4")]
		public JSONNode node; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011F5")]
		public CreatorController <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CA8")]
		public <>c__DisplayClass68_0() { }

		[Address(RVA = "0x4E8140", Offset = "0x4E7340", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(GameIO), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002CA9")]
		internal void <LoadStarterPlaces>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000433")]
	private sealed class <>c__DisplayClass68_1
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011F6")]
		public JSONNode node; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011F7")]
		public CreatorController <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CAA")]
		public <>c__DisplayClass68_1() { }

		[Address(RVA = "0x4E8210", Offset = "0x4E7410", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(GameIO), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002CAB")]
		internal void <LoadStarterPlaces>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000434")]
	private sealed class <>c__DisplayClass74_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011F8")]
		public JSONNode game; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011F9")]
		public CreatorController <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CAC")]
		public <>c__DisplayClass74_0() { }

		[Address(RVA = "0x4E82E0", Offset = "0x4E74E0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CreatorController), Member = "SetPublishModalSelectedGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002CAD")]
		internal void <DoPublish>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000435")]
	private sealed class <>c__DisplayClass76_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011FA")]
		public CreatorController <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011FB")]
		public JSONNode game; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CAE")]
		public <>c__DisplayClass76_0() { }

		[Address(RVA = "0x4E8310", Offset = "0x4E7510", Length = "0xDC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002CAF")]
		internal void <SetPublishModalSelectedGame>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000436")]
	private sealed class <AutoSaveLoop>d__85 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011FC")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40011FD")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40011FE")]
		public CreatorController <>4__this; //Field offset: 0x20

		[Token(Token = "0x17000D0D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CB3")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D0E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CB5")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CB0")]
		public <AutoSaveLoop>d__85(int <>1__state) { }

		[Address(RVA = "0x4E0480", Offset = "0x4DF680", Length = "0x3F4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(GameIO), Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
		[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Environment), Member = "GetFolderPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialFolder)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(WaitForSeconds), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6002CB2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CB3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CB5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4E0880", Offset = "0x4DFA80", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CB4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CB1")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000437")]
	private sealed class <CheckToken>d__50 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40011FF")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001200")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001201")]
		public CreatorController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001202")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x28

		[Token(Token = "0x17000D0F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CBA")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D10")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CBC")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CB6")]
		public <CheckToken>d__50(int <>1__state) { }

		[Address(RVA = "0x4E0FF0", Offset = "0x4E01F0", Length = "0x50")]
		[CalledBy(Type = typeof(<CheckToken>d__50), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002CB9")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4E08C0", Offset = "0x4DFAC0", Length = "0x65E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameIO), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(JSONNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(<CheckToken>d__50), Member = "<>m__Finally1", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CFC10")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CreatorController), Member = "RelaunchCreator", ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 7)]
		[Token(Token = "0x6002CB8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CBA")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CBC")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4E0F20", Offset = "0x4E0120", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CBB")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4E0F60", Offset = "0x4E0160", Length = "0x8C")]
		[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<WaitForImage>d__10", Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CFB40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002CB7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000438")]
	private sealed class <DoPublish>d__74 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001203")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001204")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001205")]
		public CreatorController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001206")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x28

		[Token(Token = "0x17000D11")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CC1")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D12")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CC3")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CBD")]
		public <DoPublish>d__74(int <>1__state) { }

		[Address(RVA = "0x4E24A0", Offset = "0x4E16A0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002CC0")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4E1900", Offset = "0x4E0B00", Length = "0xACC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CreatorController), Member = "SetPublishModalSelectedGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
		[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CFC80")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Transform), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6002CBF")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CC1")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CC3")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4E23D0", Offset = "0x4E15D0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CC2")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4E2410", Offset = "0x4E1610", Length = "0x8C")]
		[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<WaitForImage>d__10", Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CF800")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002CBE")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000439")]
	private sealed class <DoPublishModel>d__62 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001207")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001208")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001209")]
		public CreatorController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400120A")]
		private Enumerator<Instance> <>7__wrap1; //Field offset: 0x28
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400120B")]
		private UnityWebRequest <uwr>5__3; //Field offset: 0x40

		[Token(Token = "0x17000D13")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CC9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D14")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CCB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CC4")]
		public <DoPublishModel>d__62(int <>1__state) { }

		[Address(RVA = "0x4E1860", Offset = "0x4E0A60", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002CC7")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4E18B0", Offset = "0x4E0AB0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002CC8")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x4E1040", Offset = "0x4E0240", Length = "0x696")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WWWForm)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(WWWForm), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WWWForm), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WWWForm), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(GameIO), Member = "SaveModelToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CreatorController), Member = "GetSelectedInstances", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
		[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CF9A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6002CC6")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CC9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CCB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4E16E0", Offset = "0x4E08E0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CCA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4E1720", Offset = "0x4E0920", Length = "0x13A")]
		[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<WaitForImage>d__10", Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CFC20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CF8F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[Token(Token = "0x6002CC5")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200043A")]
	private sealed class <LoadMapFromFile>d__87 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400120C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400120D")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400120E")]
		public CreatorController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400120F")]
		public string path; //Field offset: 0x28

		[Token(Token = "0x17000D15")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CCF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D16")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CD1")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CCC")]
		public <LoadMapFromFile>d__87(int <>1__state) { }

		[Address(RVA = "0x4E4E70", Offset = "0x4E4070", Length = "0x272")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(GameIO), Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Action`1<System.Boolean>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
		[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(GameIO), Member = "ClearDatamodel", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002CCE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CCF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CD1")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4E50F0", Offset = "0x4E42F0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CD0")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CCD")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200043B")]
	private sealed class <LoadStarterPlaces>d__68 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001210")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001211")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001212")]
		public CreatorController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001213")]
		private List<ThumbnailImageTarget> <images>5__2; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001214")]
		private RectTransform <template>5__3; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4001215")]
		private UnityWebRequest <uwr>5__4; //Field offset: 0x38

		[Token(Token = "0x17000D17")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CD7")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D18")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CD9")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CD2")]
		public <LoadStarterPlaces>d__68(int <>1__state) { }

		[Address(RVA = "0x4E6140", Offset = "0x4E5340", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002CD5")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4E6190", Offset = "0x4E5390", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002CD6")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x4E5130", Offset = "0x4E4330", Length = "0xE82")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CreatorController), Member = "LoadThumbnailImages", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Polytoria.Controllers.CreatorController+ThumbnailImageTarget>)}, ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CF8E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 12)]
		[CallsUnknownMethods(Count = 8)]
		[Token(Token = "0x6002CD4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CD7")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CD9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4E5FC0", Offset = "0x4E51C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CD8")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4E6000", Offset = "0x4E5200", Length = "0x118")]
		[CalledBy(Type = "Polytoria.Controllers.ImageCacheController+<WaitForImage>d__10", Member = "System.Collections.IEnumerator.Reset", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CFA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804CFBA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x6002CD3")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200043C")]
	private sealed class <LoadThumbnailImage>d__77 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001216")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001217")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001218")]
		public string src; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001219")]
		public Image target; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400121A")]
		private UnityWebRequest <twr>5__2; //Field offset: 0x30

		[Token(Token = "0x17000D19")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CDE")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D1A")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CE0")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CDA")]
		public <LoadThumbnailImage>d__77(int <>1__state) { }

		[Address(RVA = "0x4F7EA0", Offset = "0x4F70A0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002CDD")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4F7860", Offset = "0x4F6A60", Length = "0x56D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400330")]
		[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[])}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
		[Calls(Type = typeof(DownloadHandlerTexture), Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC4C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6002CDC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CDE")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CE0")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4F7DD0", Offset = "0x4F6FD0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CDF")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4F7E10", Offset = "0x4F7010", Length = "0x8C")]
		[CalledBy(Type = typeof(UIController), Member = "set_StaminaBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIStaminaBar)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002CDB")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200043D")]
	private sealed class <LoadThumbnailImages>d__75 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400121B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400121C")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400121D")]
		public List<ThumbnailImageTarget> thumbnails; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400121E")]
		private Enumerator<ThumbnailImageTarget> <>7__wrap1; //Field offset: 0x28
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400121F")]
		private Image <target>5__3; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001220")]
		private UnityWebRequest <twr>5__4; //Field offset: 0x50

		[Token(Token = "0x17000D1B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CE6")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D1C")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CE8")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CE1")]
		public <LoadThumbnailImages>d__75(int <>1__state) { }

		[Address(RVA = "0x4F8710", Offset = "0x4F7910", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002CE4")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4F8760", Offset = "0x4F7960", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002CE5")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x4F7EF0", Offset = "0x4F70F0", Length = "0x695")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequestTexture), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400330")]
		[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ImageConversion), Member = "LoadImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Byte[])}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
		[Calls(Type = typeof(DownloadHandlerTexture), Member = "GetContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest)}, ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC530")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6002CE3")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CE6")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CE8")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4F8590", Offset = "0x4F7790", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CE7")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4F85D0", Offset = "0x4F77D0", Length = "0x13A")]
		[CalledBy(Type = typeof(UIController), Member = "set_StaminaBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIStaminaBar)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC400")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC3B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[Token(Token = "0x6002CE2")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200043E")]
	private sealed class <PublishLevelToID>d__81 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001221")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001222")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001223")]
		public CreatorController <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4001224")]
		public int id; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001225")]
		private UnityWebRequest <uwr>5__2; //Field offset: 0x30

		[Token(Token = "0x17000D1D")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CED")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D1E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CEF")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CE9")]
		public <PublishLevelToID>d__81(int <>1__state) { }

		[Address(RVA = "0x4F8F10", Offset = "0x4F8110", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x6002CEC")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x4F87B0", Offset = "0x4F79B0", Length = "0x68A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest", ReturnType = typeof(UnityWebRequestAsyncOperation))]
		[Calls(Type = typeof(LaunchController), Member = "GetActiveToken", ReturnType = typeof(string))]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnityWebRequest), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WWWForm)}, ReturnType = typeof(UnityWebRequest))]
		[Calls(Type = typeof(WWWForm), Member = "AddBinaryData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(WWWForm), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WWWForm), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(WWWForm), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(GameIO), Member = "SaveToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CreatorController), Member = "SetStatusBarMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_result", ReturnType = typeof(Result))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC3A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6002CEB")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CED")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CEF")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4F8E40", Offset = "0x4F8040", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CEE")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x4F8E80", Offset = "0x4F8080", Length = "0x8C")]
		[CalledBy(Type = typeof(UIController), Member = "set_StaminaBar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIStaminaBar)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC4D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x6002CEA")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200043F")]
	private sealed class <ShowExportGLTFDialog>d__59 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001226")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001227")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000D1F")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CF3")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D20")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CF5")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CF0")]
		public <ShowExportGLTFDialog>d__59(int <>1__state) { }

		[Address(RVA = "0x4F8F60", Offset = "0x4F8160", Length = "0x181")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "WaitForSaveDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC540")]
		[Calls(Type = typeof(CreatorController), Member = "DoExportGLTF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002CF2")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CF3")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CF5")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4F90F0", Offset = "0x4F82F0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CF4")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CF1")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000440")]
	private sealed class <ShowExportModelDialog>d__56 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001228")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001229")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000D21")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CF9")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D22")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CFB")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CF6")]
		public <ShowExportModelDialog>d__56(int <>1__state) { }

		[Address(RVA = "0x4F9130", Offset = "0x4F8330", Length = "0x181")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "WaitForSaveDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC540")]
		[Calls(Type = typeof(CreatorController), Member = "DoExportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002CF8")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CF9")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CFB")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4F92C0", Offset = "0x4F84C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002CFA")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CF7")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000441")]
	private sealed class <ShowImportModelDialog>d__64 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400122A")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400122B")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000D23")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002CFF")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D24")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002D01")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CFC")]
		public <ShowImportModelDialog>d__64(int <>1__state) { }

		[Address(RVA = "0x4F9300", Offset = "0x4F8500", Length = "0x16A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "WaitForLoadDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC540")]
		[Calls(Type = typeof(CreatorController), Member = "DoImportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[Token(Token = "0x6002CFE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CFF")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D01")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4F9470", Offset = "0x4F8670", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002D00")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002CFD")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000442")]
	private sealed class <ShowOpenDialog>d__84 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400122C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400122D")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000D25")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002D05")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D26")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002D07")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D02")]
		public <ShowOpenDialog>d__84(int <>1__state) { }

		[Address(RVA = "0x4F94B0", Offset = "0x4F86B0", Length = "0x157")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "WaitForLoadDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC540")]
		[Calls(Type = typeof(CreatorController), Member = "DoLoadMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(void))]
		[Token(Token = "0x6002D04")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D05")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D07")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4F9610", Offset = "0x4F8810", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002D06")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D03")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000443")]
	private sealed class <ShowSaveDialog>d__89 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400122E")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400122F")]
		private object <>2__current; //Field offset: 0x18

		[Token(Token = "0x17000D27")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002D0B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000D28")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002D0D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D08")]
		public <ShowSaveDialog>d__89(int <>1__state) { }

		[Address(RVA = "0x4F9650", Offset = "0x4F8850", Length = "0x16E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FileBrowser), Member = "WaitForSaveDialog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PickMode), typeof(bool), typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(IEnumerator))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1804EC540")]
		[Calls(Type = typeof(CreatorController), Member = "DoSaveFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6002D0A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D0B")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D0D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4F97C0", Offset = "0x4F89C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002D0C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D09")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200042C")]
	internal enum PaintType
	{
		None = 0,
		Color = 1,
		Material = 2,
	}

	[Token(Token = "0x200042D")]
	private struct ThumbnailImageTarget
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40011E9")]
		private string <Url>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40011EA")]
		private Image <Target>k__BackingField; //Field offset: 0x8

		[Token(Token = "0x17000D0C")]
		public Image Target
		{
			[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6002C9A")]
			 get { } //Length: 5
			[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002C9B")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000D0B")]
		public string Url
		{
			[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
			[CallerCount(Count = 140)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6002C98")]
			 get { } //Length: 4
			[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
			[CallerCount(Count = 7)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6002C99")]
			 set { } //Length: 8
		}

		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6002C9A")]
		public Image get_Target() { }

		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6002C98")]
		public string get_Url() { }

		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C9B")]
		public void set_Target(Image value) { }

		[Address(RVA = "0x425A70", Offset = "0x424C70", Length = "0x8")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C99")]
		public void set_Url(string value) { }

	}

	[Token(Token = "0x40011C3")]
	public static CreatorController singleton; //Field offset: 0x0
	[Token(Token = "0x40011C4")]
	public static bool IsCreator; //Field offset: 0x8
	[Token(Token = "0x40011C5")]
	public static string externalScriptFolder; //Field offset: 0x10
	[Token(Token = "0x40011C6")]
	private static Random random; //Field offset: 0x18
	[Token(Token = "0x40011E1")]
	private static string saveLocation; //Field offset: 0x20
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40011C2")]
	private string testCreatorToken; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40011C7")]
	public VirtualizingTreeView TreeView; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40011C8")]
	public CreatorPropertyGrid PropertyGrid; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40011C9")]
	public Image[] activateButtons; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40011CA")]
	public ColorPicker colorPicker; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40011CB")]
	public Image[] colorDisplay; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40011CC")]
	public Canvas canvas; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40011CD")]
	public RectTransform landing; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40011CE")]
	public RectTransform materialSelector; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40011CF")]
	public RectTransform publishModal; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40011D0")]
	public RectTransform contextMenu; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40011D1")]
	public ColorPicker propertyColorPicker; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40011D2")]
	public TMP_Text statusBar; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40011D3")]
	public GameObject confirmExit; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40011D4")]
	private float moveSnap; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40011D5")]
	private float rotateSnap; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40011D6")]
	private bool moveSnapEnabled; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE1")]
	[Token(Token = "0x40011D7")]
	private bool rotateSnapEnabled; //Field offset: 0xE1
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x40011D8")]
	public float autoSaveInterval; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40011D9")]
	private PaintType paintType; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x40011DA")]
	private Color defaultButtonClr; //Field offset: 0xEC
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40011DB")]
	private Dictionary<String, BaseScript> externalScriptFiles; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40011DC")]
	private FileSystemWatcher watcher; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40011DD")]
	private Color paintColor; //Field offset: 0x110
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40011DE")]
	private PartMaterial paintMaterial; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[Token(Token = "0x40011DF")]
	private int userID; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40011E0")]
	private int gameID; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x40011E2")]
	private Vector3 mouseDownPosition; //Field offset: 0x12C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40011E3")]
	private string <CreatorToken>k__BackingField; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40011E4")]
	private List<Instance> selectionQueue; //Field offset: 0x140

	[Token(Token = "0x17000D0A")]
	public private string CreatorToken
	{
		[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C32")]
		 get { } //Length: 8
		[Address(RVA = "0x4DCCA0", Offset = "0x4DBEA0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002C33")]
		private set { } //Length: 19
	}

	[Address(RVA = "0x4DCA20", Offset = "0x4DBC20", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002C94")]
	private static CreatorController() { }

	[Address(RVA = "0x4DCAF0", Offset = "0x4DBCF0", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C93")]
	public CreatorController() { }

	[Address(RVA = "0x4DB970", Offset = "0x4DAB70", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6002C95")]
	private void <CheckToken>b__50_0(bool result) { }

	[Address(RVA = "0x4DB9D0", Offset = "0x4DABD0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6002C96")]
	private void <LoadMapFromFile>b__87_0(bool r) { }

	[Address(RVA = "0x4D1C70", Offset = "0x4D0E70", Length = "0x84")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C8F")]
	public Instance Add(string instanceClass, string parentClass) { }

	[Address(RVA = "0x4CFD50", Offset = "0x4CEF50", Length = "0x7BA")]
	[CalledBy(Type = typeof(CreatorController), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Instance))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddTruss", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddScript", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddSound", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddLocalScript", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddModuleScript", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddRemoteEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "AddUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Plane), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "GetWorldAABB", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Plane), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C88")]
	public Instance AddInstance(string className, Instance parent = null, bool ignorePlacement = false) { }

	[Address(RVA = "0x4D0510", Offset = "0x4CF710", Length = "0x8B")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C8C")]
	public void AddLocalScript() { }

	[Address(RVA = "0x4D05A0", Offset = "0x4CF7A0", Length = "0x8B")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C8D")]
	public void AddModuleScript() { }

	[Address(RVA = "0x4D0630", Offset = "0x4CF830", Length = "0x89F")]
	[CalledBy(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Plane), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "GetWorldAABB", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Part), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Part), Member = "set_Shape", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C89")]
	public void AddPart(PartShape shape = 0, string name = "Brick") { }

	[Address(RVA = "0x4D0ED0", Offset = "0x4D00D0", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CreatorController), Member = "AddPart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartShape), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002C83")]
	public void AddPart(string shape) { }

	[Address(RVA = "0x4D0FD0", Offset = "0x4D01D0", Length = "0x8B")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C8E")]
	public void AddRemoteEvent() { }

	[Address(RVA = "0x4D1060", Offset = "0x4D0260", Length = "0x8B")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C8A")]
	public void AddScript() { }

	[Address(RVA = "0x4D10F0", Offset = "0x4D02F0", Length = "0x864")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&), typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "GetWorldAABB", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(Plane), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Part), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Screen), Member = "get_width", ReturnType = typeof(int))]
	[Calls(Type = typeof(Screen), Member = "get_height", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C91")]
	public void AddSeat(string name = "Seat") { }

	[Address(RVA = "0x4D1960", Offset = "0x4D0B60", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Token(Token = "0x6002C8B")]
	public void AddSound() { }

	[Address(RVA = "0x4D19B0", Offset = "0x4D0BB0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Token(Token = "0x6002C87")]
	public void AddTruss() { }

	[Address(RVA = "0x4D1A00", Offset = "0x4D0C00", Length = "0x26C")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CreatorController), Member = "AddInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance), typeof(bool)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6002C90")]
	public void AddUI(string instanceClass) { }

	[Address(RVA = "0x4D1D00", Offset = "0x4D0F00", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<AutoSaveLoop>d__85))]
	[Token(Token = "0x6002C63")]
	private IEnumerator AutoSaveLoop() { }

	[Address(RVA = "0x4D1D70", Offset = "0x4D0F70", Length = "0x2BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RLDApp), Member = "add_Initialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RLDAppInitializedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTObjectSelection), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSelectionChangedHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "add_wantsToQuit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002C37")]
	private void Awake() { }

	[Address(RVA = "0x4D2030", Offset = "0x4D1230", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<CheckToken>d__50))]
	[Token(Token = "0x6002C40")]
	private IEnumerator CheckToken() { }

	[Address(RVA = "0x4D20A0", Offset = "0x4D12A0", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C7E")]
	private List<Instance> ChildrenOf(Instance parent) { }

	[Address(RVA = "0x4DCBF0", Offset = "0x4DBDF0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE900")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C5C")]
	private static int chmod(string path, int mode) { }

	[Address(RVA = "0x4D2180", Offset = "0x4D1380", Length = "0x409")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToUnixTimeSeconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Transform), Member = "set_rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DiscordController), Member = "UpdateActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Activity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameIO), Member = "ClearDatamodel", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Token(Token = "0x6002C53")]
	public void ClearWorkspace() { }

	[Address(RVA = "0x4D2590", Offset = "0x4D1790", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C82")]
	public void CloseContextMenu() { }

	[Address(RVA = "0x4D25D0", Offset = "0x4D17D0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C54")]
	public void CloseStartScreen() { }

	[Address(RVA = "0x4D2610", Offset = "0x4D1810", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CreatorController), Member = "GetSelectedInstancesTreeView", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
	[Calls(Type = typeof(ClipboardController), Member = "CopyInstancesToClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C71")]
	public void CopySelectionToClipboard() { }

	[Address(RVA = "0x4D26C0", Offset = "0x4D18C0", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CreatorController), Member = "GetSelectedInstancesTreeView", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
	[Calls(Type = typeof(ClipboardController), Member = "CopyInstancesToClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "DeleteSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C72")]
	public void CutSelectionToClipboard() { }

	[Address(RVA = "0x4D27F0", Offset = "0x4D19F0", Length = "0x527")]
	[CalledBy(Type = typeof(CreatorController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "CutSelectionToClipboard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(DeleteSelectedObjectsAction), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(DeleteSelectedObjectsAction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(ObjectSelectionSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectSelectionSnapshot), Member = "Snapshot", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C3D")]
	public void DeleteSelection() { }

	[Address(RVA = "0x4D2D20", Offset = "0x4D1F20", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
	[Token(Token = "0x6002C36")]
	public void DoExit() { }

	[Address(RVA = "0x4D2D60", Offset = "0x4D1F60", Length = "0xBD")]
	[CalledBy(Type = typeof(<ShowExportGLTFDialog>d__59), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C4A")]
	private static void DoExportGLTF(string path) { }

	[Address(RVA = "0x4D2E20", Offset = "0x4D2020", Length = "0x216")]
	[CalledBy(Type = typeof(<ShowExportModelDialog>d__56), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CreatorController), Member = "GetSelectedInstances", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GameIO), Member = "SaveModelToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C47")]
	private static void DoExportModel(string path) { }

	[Address(RVA = "0x4D3040", Offset = "0x4D2240", Length = "0x31C")]
	[CalledBy(Type = typeof(<ShowImportModelDialog>d__64), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "GetWorldAABB", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameIO), Member = "LoadModelFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C4F")]
	private static void DoImportModel(String[] paths) { }

	[Address(RVA = "0x4D3360", Offset = "0x4D2560", Length = "0x44F")]
	[CalledBy(Type = typeof(<ShowOpenDialog>d__84), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToUnixTimeSeconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(DiscordController), Member = "UpdateActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Activity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C64")]
	private static void DoLoadMap(String[] paths) { }

	[Address(RVA = "0x4D3820", Offset = "0x4D2A20", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoPublish>d__74))]
	[Token(Token = "0x6002C58")]
	private IEnumerator DoPublish() { }

	[Address(RVA = "0x4D37B0", Offset = "0x4D29B0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<DoPublishModel>d__62))]
	[Token(Token = "0x6002C4C")]
	private IEnumerator DoPublishModel() { }

	[Address(RVA = "0x4D3890", Offset = "0x4D2A90", Length = "0x493")]
	[CalledBy(Type = typeof(<ShowSaveDialog>d__89), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(GameIO), Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToUnixTimeSeconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DiscordController), Member = "UpdateActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Activity)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C68")]
	private static void DoSaveFile(string path) { }

	[Address(RVA = "0x4D3D30", Offset = "0x4D2F30", Length = "0x38A")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Instance), Member = "Clone", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C3E")]
	public void DuplicateSelection() { }

	[Address(RVA = "0x4D40C0", Offset = "0x4D32C0", Length = "0x544")]
	[CalledBy(Type = typeof(CreatorController), Member = "OnItemDoubleClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ItemArgs)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(File), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(File), Member = "CreateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StreamWriter))]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Char>)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Repeat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C56")]
	private void EditScript(BaseScript script) { }

	[Address(RVA = "0x4D4610", Offset = "0x4D3810", Length = "0x17A")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C48")]
	public void ExportGLTF() { }

	[Address(RVA = "0x4D4790", Offset = "0x4D3990", Length = "0x2A5")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CreatorController), Member = "ShowExportModelDialog", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CreatorController), Member = "GetSelectedInstances", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002C45")]
	public void ExportModel() { }

	[Address(RVA = "0x4D4A40", Offset = "0x4D3C40", Length = "0x278")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C61")]
	public void FileOpen() { }

	[Address(RVA = "0x4D4CC0", Offset = "0x4D3EC0", Length = "0x446")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GameIO), Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C66")]
	public void FileSave(bool saveAs) { }

	[Address(RVA = "0x4D5110", Offset = "0x4D4310", Length = "0x215")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ObjectSelectEntireHierarchy), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C3A")]
	private void GameLoaded() { }

	[Address(RVA = "0x3F5880", Offset = "0x3F4A80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C32")]
	public string get_CreatorToken() { }

	[Address(RVA = "0x4D5330", Offset = "0x4D4530", Length = "0x18F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002C41")]
	private Dictionary<String, String> GetCommandLineArgs() { }

	[Address(RVA = "0x4D57A0", Offset = "0x4D49A0", Length = "0x213")]
	[CalledBy(Type = typeof(<DoPublishModel>d__62), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CreatorController), Member = "GroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "UngroupSelection", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "ExportModel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "DoExportModel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorThumbnailGenerator), Member = "TestRender", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_SelectedObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002C51")]
	public static List<Instance> GetSelectedInstances() { }

	[Address(RVA = "0x4D54C0", Offset = "0x4D46C0", Length = "0x2D7")]
	[CalledBy(Type = typeof(CreatorController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "CopySelectionToClipboard", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "CutSelectionToClipboard", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C70")]
	public List<Instance> GetSelectedInstancesTreeView() { }

	[Address(RVA = "0x4D59C0", Offset = "0x4D4BC0", Length = "0x87A")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Instance), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(DynamicInstance), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Renderer), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Instance), Member = "get_DescendantLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(Collider), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CreatorController), Member = "GetSelectedInstances", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x6002C43")]
	public void GroupSelection() { }

	[Address(RVA = "0x4D6240", Offset = "0x4D5440", Length = "0x17A")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Filter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FileBrowser), Member = "SetFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Filter[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileBrowser), Member = "SetDefaultFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C4D")]
	public void ImportModel() { }

	[Address(RVA = "0x4D63C0", Offset = "0x4D55C0", Length = "0x2FA")]
	[CalledBy(Type = typeof(CreatorController), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C6F")]
	private bool IsEditingTextField() { }

	[Address(RVA = "0x4D66C0", Offset = "0x4D58C0", Length = "0x129")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C92")]
	public static bool IsPointerOverUIObject() { }

	[Address(RVA = "0x4D67F0", Offset = "0x4D59F0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<LoadMapFromFile>d__87))]
	[Token(Token = "0x6002C65")]
	private IEnumerator LoadMapFromFile(string path) { }

	[Address(RVA = "0x4D6880", Offset = "0x4D5A80", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<LoadStarterPlaces>d__68))]
	[Token(Token = "0x6002C52")]
	private IEnumerator LoadStarterPlaces() { }

	[Address(RVA = "0x4D68F0", Offset = "0x4D5AF0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<LoadThumbnailImage>d__77))]
	[Token(Token = "0x6002C5B")]
	private IEnumerator LoadThumbnailImage(string src, Image target) { }

	[Address(RVA = "0x4D6980", Offset = "0x4D5B80", Length = "0x6D")]
	[CalledBy(Type = typeof(<LoadStarterPlaces>d__68), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<LoadThumbnailImages>d__75))]
	[Token(Token = "0x6002C59")]
	private IEnumerator LoadThumbnailImages(List<ThumbnailImageTarget> thumbnails) { }

	[Address(RVA = "0x4D69F0", Offset = "0x4D5BF0", Length = "0x1AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetGizmoById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Gizmo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Gizmo), Member = "add_PostDragEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPostDragEndHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6002C3B")]
	private void OnAppInitialized() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C7A")]
	private void OnItemBeginDrag(object sender, ItemArgs e) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C79")]
	private void OnItemBeginDrop(object sender, ItemDropCancelArgs e) { }

	[Address(RVA = "0x4D6BA0", Offset = "0x4D5DA0", Length = "0x1E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C78")]
	private void OnItemDataBinding(object sender, VirtualizingTreeViewItemDataBindingArgs e) { }

	[Address(RVA = "0x4D6D90", Offset = "0x4D5F90", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CreatorController), Member = "EditScript", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseScript)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C80")]
	private void OnItemDoubleClick(object sender, ItemArgs e) { }

	[Address(RVA = "0x4D6EC0", Offset = "0x4D60C0", Length = "0x712")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "set_Items", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Transform), Member = "SetAsLastSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetSiblingIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Instance), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C7F")]
	private void OnItemDrop(object sender, ItemDropArgs e) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C7B")]
	private void OnItemEndDrag(object sender, ItemArgs e) { }

	[Address(RVA = "0x4D75E0", Offset = "0x4D67E0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6002C7C")]
	private void OnItemExpanding(object sender, VirtualizingItemExpandingArgs e) { }

	[Address(RVA = "0x4D7690", Offset = "0x4D6890", Length = "0x3B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_SelectedObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C81")]
	private void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args) { }

	[Address(RVA = "0x4D7A50", Offset = "0x4D6C50", Length = "0x2A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CreatorPropertyGrid), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelection), Member = "get_SelectedObjects", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CreatorPropertyGrid), Member = "SetPropertyGridItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002C38")]
	private void OnPostDragEnd(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x4D7D00", Offset = "0x4D6F00", Length = "0x520")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CreatorPropertyGrid), Member = "SetPropertyGridItems", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CreatorPropertyGrid), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C7D")]
	private void OnTreeSelectionChanged(object sender, SelectionChangedArgs e) { }

	[Address(RVA = "0x4D8230", Offset = "0x4D7430", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(ClipboardController), Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C73")]
	public void PasteFromClipboard() { }

	[Address(RVA = "0x4D8330", Offset = "0x4D7530", Length = "0x23")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C35")]
	public void PromptExit() { }

	[Address(RVA = "0x4D8360", Offset = "0x4D7560", Length = "0x4A1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "GetItemContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(VirtualizingItemContainer))]
	[Calls(Type = typeof(BoxGizmo), Member = "FitBoxToTargetHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "GetGizmoById", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Gizmo))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(DynamicInstance), Member = "get_Position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "get_WorkGizmo", ReturnType = typeof(Gizmo))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6002C39")]
	private void PropertyGrid_ValueChanged(object obj, PropertyInfo propertyInfo) { }

	[Address(RVA = "0x4D88A0", Offset = "0x4D7AA0", Length = "0x71")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C57")]
	public void PublishGame() { }

	[Address(RVA = "0x4D8810", Offset = "0x4D7A10", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C5E")]
	public void PublishGameOverwrite(int id) { }

	[Address(RVA = "0x4D8920", Offset = "0x4D7B20", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<PublishLevelToID>d__81))]
	[Token(Token = "0x6002C5F")]
	private IEnumerator PublishLevelToID(int id) { }

	[Address(RVA = "0x4D89A0", Offset = "0x4D7BA0", Length = "0x71")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C4B")]
	public void PublishModel() { }

	[Address(RVA = "0x4D8A20", Offset = "0x4D7C20", Length = "0x16A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "Repeat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Char>)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Token(Token = "0x6002C60")]
	public static string RandomString(int length) { }

	[Address(RVA = "0x4D8B90", Offset = "0x4D7D90", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTUndoRedo), Member = "Redo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C86")]
	public void Redo() { }

	[Address(RVA = "0x4D8C00", Offset = "0x4D7E00", Length = "0x95")]
	[CalledBy(Type = typeof(<CheckToken>d__50), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "Quit", ReturnType = typeof(void))]
	[Token(Token = "0x6002C42")]
	private void RelaunchCreator() { }

	[Address(RVA = "0x4D8CA0", Offset = "0x4D7EA0", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(File), Member = "ReadAllText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C55")]
	private void ScriptEditedExternally(object sender, FileSystemEventArgs e) { }

	[Address(RVA = "0x4D8DE0", Offset = "0x4D7FE0", Length = "0x2DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002C84")]
	public void SelectChildren() { }

	[Address(RVA = "0x4DCCA0", Offset = "0x4DBEA0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C33")]
	private void set_CreatorToken(string value) { }

	[Address(RVA = "0x4D90C0", Offset = "0x4D82C0", Length = "0x528")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelection), Member = "SetEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelectionGizmos), Member = "SetWorkGizmo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x6002C6D")]
	public void SetActiveGizmo(string name) { }

	[Address(RVA = "0x4D95F0", Offset = "0x4D87F0", Length = "0x183")]
	[CalledBy(Type = typeof(CreatorController), Member = "SetMoveSnapSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(MoveGizmoSettings3D), Member = "SetXSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoSettings3D), Member = "SetYSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MoveGizmoSettings3D), Member = "SetZSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002C69")]
	public void SetMoveSnapEnabled(bool enabled) { }

	[Address(RVA = "0x4D9780", Offset = "0x4D8980", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CreatorController), Member = "SetMoveSnapEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002C6A")]
	public void SetMoveSnapSize(string snapString) { }

	[Address(RVA = "0x4D97C0", Offset = "0x4D89C0", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C75")]
	public void SetPaintColor(Color c) { }

	[Address(RVA = "0x4D9880", Offset = "0x4D8A80", Length = "0x59B")]
	[CalledBy(Type = typeof(<>c__DisplayClass74_0), Member = "<DoPublish>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<DoPublish>d__74), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UnityEventBase), Member = "RemoveAllListeners", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(JSONNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTime), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6002C5A")]
	public void SetPublishModalSelectedGame(JSONNode game) { }

	[Address(RVA = "0x4D9E20", Offset = "0x4D9020", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "SetAxisSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C6B")]
	public void SetRotateSnapEnabled(bool enabled) { }

	[Address(RVA = "0x4D9F30", Offset = "0x4D9130", Length = "0x11E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RotationGizmoSettings3D), Member = "SetAxisSnapStep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C6C")]
	public void SetRotateSnapSize(string snapString) { }

	[Address(RVA = "0x4DA050", Offset = "0x4D9250", Length = "0x2D")]
	[CalledBy(Type = typeof(ClipboardController), Member = "CopyInstancesToClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipboardController), Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<PublishLevelToID>d__81), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002C3F")]
	public void SetStatusBarMessage(string message) { }

	[Address(RVA = "0x4DA080", Offset = "0x4D9280", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C74")]
	private void ShowContextMenu() { }

	[Address(RVA = "0x4DA190", Offset = "0x4D9390", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ShowExportGLTFDialog>d__59))]
	[Token(Token = "0x6002C49")]
	private IEnumerator ShowExportGLTFDialog() { }

	[Address(RVA = "0x4DA1E0", Offset = "0x4D93E0", Length = "0x47")]
	[CalledBy(Type = typeof(CreatorController), Member = "ExportModel", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ShowExportModelDialog>d__56))]
	[Token(Token = "0x6002C46")]
	private IEnumerator ShowExportModelDialog() { }

	[Address(RVA = "0x4DA230", Offset = "0x4D9430", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ShowImportModelDialog>d__64))]
	[Token(Token = "0x6002C4E")]
	private IEnumerator ShowImportModelDialog() { }

	[Address(RVA = "0x4DA280", Offset = "0x4D9480", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ShowOpenDialog>d__84))]
	[Token(Token = "0x6002C62")]
	private IEnumerator ShowOpenDialog() { }

	[Address(RVA = "0x4DA2D0", Offset = "0x4D94D0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<ShowSaveDialog>d__89))]
	[Token(Token = "0x6002C67")]
	private IEnumerator ShowSaveDialog() { }

	[Address(RVA = "0x4DA320", Offset = "0x4D9520", Length = "0xFEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl`1), Member = "add_ItemDataBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.EventHandler`1<TDataBindingArgs>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "add_SelectionChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<Battlehub.UIControls.SelectionChangedArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "add_ItemExpanding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<Battlehub.UIControls.VirtualizingItemExpandingArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "add_ItemBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<Battlehub.UIControls.ItemArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "add_ItemDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<Battlehub.UIControls.ItemDropArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "add_ItemBeginDrop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<Battlehub.UIControls.ItemDropCancelArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "add_ItemEndDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<Battlehub.UIControls.ItemArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "add_ItemDoubleClick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.EventHandler`1<Battlehub.UIControls.ItemArgs>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DirectoryInfo))]
	[Calls(Type = typeof(FileSystemWatcher), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "set_Filter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "set_NotifyFilter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotifyFilters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "set_EnableRaisingEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "set_IncludeSubdirectories", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FileSystemWatcher), Member = "add_Changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FileSystemEventHandler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Application), Member = "get_version", ReturnType = typeof(string))]
	[Calls(Type = typeof(GameIO), Member = "PostMapLoad", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_Now", ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToUnixTimeSeconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(DiscordController), Member = "UpdateActivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Activity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(QualitySettings), Member = "set_vSyncCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "set_targetFrameRate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Game), Member = "add_Loaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enum), Member = "GetNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform)}, ReturnType = "T")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002C3C")]
	private void Start() { }

	[Address(RVA = "0x4DB310", Offset = "0x4DA510", Length = "0x31D")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE900")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(GameIO), Member = "SaveToFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Application), Member = "get_temporaryCachePath", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8D0")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerable), Member = "Repeat", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult", typeof(int)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Char>)}, ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(Application), Member = "OpenURL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002C5D")]
	public void TestGame() { }

	[Address(RVA = "0x4DB630", Offset = "0x4DA830", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C76")]
	public void ToggleColorPicker() { }

	[Address(RVA = "0x4DB6A0", Offset = "0x4DA8A0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C77")]
	public void ToggleMaterialPicker() { }

	[Address(RVA = "0x4DB710", Offset = "0x4DA910", Length = "0x25B")]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<>c", Member = "<InsertModel>b__24_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(RTFocusCamera), Member = "Focus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "GetWorldAABB", ReturnType = typeof(AABB))]
	[Calls(Type = typeof(RTObjectSelection), Member = "SetSelectedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C50")]
	public void ToolboxModelAdded(Model i) { }

	[Address(RVA = "0x4DBA30", Offset = "0x4DAC30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTUndoRedo), Member = "Undo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002C85")]
	public void Undo() { }

	[Address(RVA = "0x4DBAA0", Offset = "0x4DACA0", Length = "0x585")]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorMenuCmdController), Member = "OnCmd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "Collapse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(VirtualizingTreeView), Member = "RemoveChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Instance), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "get_DescendantLevel", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CreatorController), Member = "GetSelectedInstances", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x6002C44")]
	public void UngroupSelection() { }

	[Address(RVA = "0x4DC030", Offset = "0x4DB230", Length = "0x9ED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CreatorController), Member = "GetSelectedInstancesTreeView", ReturnType = typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(VirtualizingItemsControl), Member = "get_SelectedItemsCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Enumerable), Member = "Cast", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(ClipboardController), Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
	[Calls(Type = typeof(EventSystem), Member = "get_current", ReturnType = typeof(EventSystem))]
	[Calls(Type = typeof(EventSystem), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PointerEventData), typeof(System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
	[Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(Physics), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RaycastHit), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Part), Member = "set_Material", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PartMaterial)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventSystem)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ClipboardController), Member = "CopyInstancesToClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Polytoria.Datamodel.Instance>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "DeleteSelection", ReturnType = typeof(void))]
	[Calls(Type = typeof(Part), Member = "set_Color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
	[Calls(Type = typeof(RTObjectSelection), Member = "ClearSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTObjectSelection), Member = "AppendObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CreatorController), Member = "IsEditingTextField", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002C6E")]
	private void Update() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C34")]
	private static bool WantsToQuit() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C97")]
	public virtual bool Weaved() { }

}

