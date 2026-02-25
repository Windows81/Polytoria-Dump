namespace SimpleJSON;

[DefaultMember("Item")]
[Token(Token = "0x2000027")]
public abstract class JSONNode
{
	[CompilerGenerated]
	[Token(Token = "0x200002D")]
	private sealed class <get_Children>d__39 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000170")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000171")]
		private JSONNode <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000172")]
		private int <>l__initialThreadId; //Field offset: 0x20

		[Token(Token = "0x1700004F")]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003DD")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000050")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003DF")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DA")]
		public <get_Children>d__39(int <>1__state) { }

		[Address(RVA = "0x314B80", Offset = "0x313D80", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60003DC")]
		private override bool MoveNext() { }

		[Address(RVA = "0x314B90", Offset = "0x313D90", Length = "0x8B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E0")]
		private override IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DD")]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current() { }

		[Address(RVA = "0x314B90", Offset = "0x313D90", Length = "0x8B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E1")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DF")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x314C20", Offset = "0x313E20", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60003DE")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003DB")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002E")]
	private sealed class <get_DeepChildren>d__41 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000173")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000174")]
		private JSONNode <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000175")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000176")]
		public JSONNode <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000177")]
		private IEnumerator<JSONNode> <>7__wrap1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000178")]
		private IEnumerator<JSONNode> <>7__wrap2; //Field offset: 0x38

		[Token(Token = "0x17000051")]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003E7")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000052")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x60003E9")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E2")]
		public <get_DeepChildren>d__41(int <>1__state) { }

		[Address(RVA = "0x3151A0", Offset = "0x3143A0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60003E5")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x3151F0", Offset = "0x3143F0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Token(Token = "0x60003E6")]
		private void <>m__Finally2() { }

		[Address(RVA = "0x314C60", Offset = "0x313E60", Length = "0x308")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(JSONNode), Member = "get_DeepChildren", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<SimpleJSON.JSONNode>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5800")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003E4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x314F70", Offset = "0x314170", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EA")]
		private override IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E7")]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current() { }

		[Address(RVA = "0x314F70", Offset = "0x314170", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EB")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003E9")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x315010", Offset = "0x314210", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x60003E8")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x315050", Offset = "0x314250", Length = "0x14A")]
		[CalledBy(Type = typeof(UnitySourceGeneratedAssemblyMonoScriptTypes_v1), Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F5A60")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DebuggerHidden]
		[Token(Token = "0x60003E3")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000028")]
	internal struct Enumerator
	{
		[Token(Token = "0x2000029")]
		private enum Type
		{
			None = 0,
			Array = 1,
			Object = 2,
		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000165")]
		private Type type; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000166")]
		private Enumerator<String, JSONNode> m_Object; //Field offset: 0x8
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000167")]
		private Enumerator<JSONNode> m_Array; //Field offset: 0x30

		[Token(Token = "0x1700004A")]
		public KeyValuePair<String, JSONNode> Current
		{
			[Address(RVA = "0x2FC860", Offset = "0x2FBA60", Length = "0xA0")]
			[CalledBy(Type = "Polytoria.Networking.PTNetworkManager+<HeartbeatLoop>d__33", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublish>d__74", Member = "MoveNext", ReturnType = typeof(bool))]
			[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadStarterPlaces>d__68", Member = "MoveNext", ReturnType = typeof(bool))]
			[CallerCount(Count = 7)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60003C4")]
			 get { } //Length: 160
		}

		[Token(Token = "0x17000049")]
		public bool IsValid
		{
			[Address(RVA = "0x2FC900", Offset = "0x2FBB00", Length = "0x7")]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[DeduplicatedMethod]
			[Token(Token = "0x60003C1")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x2FC820", Offset = "0x2FBA20", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60003C2")]
		public Enumerator(Enumerator<JSONNode> aArrayEnum) { }

		[Address(RVA = "0x2FC7D0", Offset = "0x2FB9D0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60003C3")]
		public Enumerator(Enumerator<String, JSONNode> aDictEnum) { }

		[Address(RVA = "0x2FC860", Offset = "0x2FBA60", Length = "0xA0")]
		[CalledBy(Type = "Polytoria.Networking.PTNetworkManager+<HeartbeatLoop>d__33", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublish>d__74", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadStarterPlaces>d__68", Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003C4")]
		public KeyValuePair<String, JSONNode> get_Current() { }

		[Address(RVA = "0x2FC900", Offset = "0x2FBB00", Length = "0x7")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C1")]
		public bool get_IsValid() { }

		[Address(RVA = "0x2FC760", Offset = "0x2FB960", Length = "0x6D")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C5")]
		public bool MoveNext() { }

	}

	[Token(Token = "0x200002B")]
	internal struct KeyEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016D")]
		private Enumerator m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x1700004C")]
		public JSONNode Current
		{
			[Address(RVA = "0x300EA0", Offset = "0x3000A0", Length = "0xC1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60003CF")]
			 get { } //Length: 193
		}

		[Address(RVA = "0x300D20", Offset = "0x2FFF20", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CC")]
		public KeyEnumerator(Enumerator<JSONNode> aArrayEnum) { }

		[Address(RVA = "0x300DC0", Offset = "0x2FFFC0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CD")]
		public KeyEnumerator(Enumerator<String, JSONNode> aDictEnum) { }

		[Address(RVA = "0x300E60", Offset = "0x300060", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CE")]
		public KeyEnumerator(Enumerator aEnumerator) { }

		[Address(RVA = "0x300EA0", Offset = "0x3000A0", Length = "0xC1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003CF")]
		public JSONNode get_Current() { }

		[Address(RVA = "0x300CF0", Offset = "0x2FFEF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D1")]
		public KeyEnumerator GetEnumerator() { }

		[Address(RVA = "0x2FC760", Offset = "0x2FB960", Length = "0x6D")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60003D0")]
		public bool MoveNext() { }

	}

	[Token(Token = "0x200002C")]
	internal class LinqEnumerator : IEnumerator<KeyValuePair`2<String, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair`2<String, JSONNode>>, IEnumerable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400016E")]
		private JSONNode m_Node; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400016F")]
		private Enumerator m_Enumerator; //Field offset: 0x18

		[Token(Token = "0x1700004D")]
		public override KeyValuePair<String, JSONNode> Current
		{
			[Address(RVA = "0x303960", Offset = "0x302B60", Length = "0xAE")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60003D3")]
			 get { } //Length: 174
		}

		[Token(Token = "0x1700004E")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x3037F0", Offset = "0x3029F0", Length = "0xC0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60003D4")]
			private get { } //Length: 192
		}

		[Address(RVA = "0x3038B0", Offset = "0x302AB0", Length = "0xA1")]
		[CalledBy(Type = typeof(LinqEnumerator), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>>))]
		[CalledBy(Type = typeof(LinqEnumerator), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CalledBy(Type = typeof(JSONNode), Member = "get_Linq", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>>))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(JSONNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003D2")]
		internal LinqEnumerator(JSONNode aNode) { }

		[Address(RVA = "0x3035F0", Offset = "0x3027F0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60003D6")]
		public override void Dispose() { }

		[Address(RVA = "0x303960", Offset = "0x302B60", Length = "0xAE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003D3")]
		public override KeyValuePair<String, JSONNode> get_Current() { }

		[Address(RVA = "0x303630", Offset = "0x302830", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(LinqEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
		[Token(Token = "0x60003D7")]
		public override IEnumerator<KeyValuePair`2<String, JSONNode>> GetEnumerator() { }

		[Address(RVA = "0x303690", Offset = "0x302890", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Token(Token = "0x60003D5")]
		public override bool MoveNext() { }

		[Address(RVA = "0x303700", Offset = "0x302900", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(JSONNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60003D8")]
		public override void Reset() { }

		[Address(RVA = "0x303790", Offset = "0x302990", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(LinqEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
		[Token(Token = "0x60003D9")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x3037F0", Offset = "0x3029F0", Length = "0xC0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003D4")]
		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[Token(Token = "0x200002A")]
	internal struct ValueEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400016C")]
		private Enumerator m_Enumerator; //Field offset: 0x0

		[Token(Token = "0x1700004B")]
		public JSONNode Current
		{
			[Address(RVA = "0x316680", Offset = "0x315880", Length = "0x14F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x60003C9")]
			 get { } //Length: 335
		}

		[Address(RVA = "0x300D20", Offset = "0x2FFF20", Length = "0x92")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C6")]
		public ValueEnumerator(Enumerator<JSONNode> aArrayEnum) { }

		[Address(RVA = "0x300DC0", Offset = "0x2FFFC0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C7")]
		public ValueEnumerator(Enumerator<String, JSONNode> aDictEnum) { }

		[Address(RVA = "0x300E60", Offset = "0x300060", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60003C8")]
		public ValueEnumerator(Enumerator aEnumerator) { }

		[Address(RVA = "0x316680", Offset = "0x315880", Length = "0x14F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003C9")]
		public JSONNode get_Current() { }

		[Address(RVA = "0x300CF0", Offset = "0x2FFEF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CB")]
		public ValueEnumerator GetEnumerator() { }

		[Address(RVA = "0x2FC760", Offset = "0x2FB960", Length = "0x6D")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2+Enumerator<System.Object, System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60003CA")]
		public bool MoveNext() { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000161")]
	private static StringBuilder m_EscapeBuilder; //Field offset: 0x80000000
	[Token(Token = "0x4000160")]
	public static bool forceASCII; //Field offset: 0x0
	[Token(Token = "0x4000162")]
	public static JSONContainerType VectorContainerType; //Field offset: 0x4
	[Token(Token = "0x4000163")]
	public static JSONContainerType QuaternionContainerType; //Field offset: 0x8
	[Token(Token = "0x4000164")]
	public static JSONContainerType RectContainerType; //Field offset: 0xC

	[Token(Token = "0x17000046")]
	public override JSONArray AsArray
	{
		[Address(RVA = "0x2DBD90", Offset = "0x2DAF90", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000388")]
		 get { } //Length: 110
	}

	[Token(Token = "0x17000045")]
	public override bool AsBool
	{
		[Address(RVA = "0x2DBE00", Offset = "0x2DB000", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000386")]
		 get { } //Length: 142
		[Address(RVA = "0x2DCE60", Offset = "0x2DC060", Length = "0x75")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000387")]
		 set { } //Length: 117
	}

	[Token(Token = "0x17000042")]
	public override double AsDouble
	{
		[Address(RVA = "0x2DBE90", Offset = "0x2DB090", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000380")]
		 get { } //Length: 86
		[Address(RVA = "0x2DCEE0", Offset = "0x2DC0E0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000381")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000044")]
	public override float AsFloat
	{
		[Address(RVA = "0x2DBEF0", Offset = "0x2DB0F0", Length = "0x20")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000384")]
		 get { } //Length: 32
		[Address(RVA = "0x2DCF20", Offset = "0x2DC120", Length = "0x18")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000385")]
		 set { } //Length: 24
	}

	[Token(Token = "0x17000043")]
	public override int AsInt
	{
		[Address(RVA = "0x2DBF10", Offset = "0x2DB110", Length = "0x20")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000382")]
		 get { } //Length: 32
		[Address(RVA = "0x2DCF40", Offset = "0x2DC140", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000383")]
		 set { } //Length: 28
	}

	[Token(Token = "0x17000047")]
	public override JSONObject AsObject
	{
		[Address(RVA = "0x2DBF30", Offset = "0x2DB130", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000389")]
		 get { } //Length: 110
	}

	[Token(Token = "0x1700003D")]
	public override IEnumerable<JSONNode> Children
	{
		[Address(RVA = "0x2DBFA0", Offset = "0x2DB1A0", Length = "0x4A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[IteratorStateMachine(typeof(<get_Children>d__39))]
		[Token(Token = "0x6000377")]
		 get { } //Length: 74
	}

	[Token(Token = "0x17000035")]
	public override int Count
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000369")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700003E")]
	public IEnumerable<JSONNode> DeepChildren
	{
		[Address(RVA = "0x2DBFF0", Offset = "0x2DB1F0", Length = "0x70")]
		[CalledBy(Type = typeof(<get_DeepChildren>d__41), Member = "MoveNext", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[IteratorStateMachine(typeof(<get_DeepChildren>d__41))]
		[Token(Token = "0x6000378")]
		 get { } //Length: 112
	}

	[Token(Token = "0x17000048")]
	internal static StringBuilder EscapeBuilder
	{
		[Address(RVA = "0x2DC070", Offset = "0x2DB270", Length = "0x9B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000399")]
		internal get { } //Length: 155
	}

	[Token(Token = "0x1700003C")]
	public override bool Inline
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000370")]
		 get { } //Length: 3
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000371")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700003A")]
	public override bool IsArray
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000038")]
	public override bool IsBoolean
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036C")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000039")]
	public override bool IsNull
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036D")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000036")]
	public override bool IsNumber
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700003B")]
	public override bool IsObject
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000037")]
	public override bool IsString
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600036B")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000033")]
	public override JSONNode Item
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000365")]
		 get { } //Length: 3
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000366")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000032")]
	public override JSONNode Item
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000363")]
		 get { } //Length: 3
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000364")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000040")]
	public KeyEnumerator Keys
	{
		[Address(RVA = "0x2DC120", Offset = "0x2DB320", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600037E")]
		 get { } //Length: 93
	}

	[Token(Token = "0x1700003F")]
	public IEnumerable<KeyValuePair`2<String, JSONNode>> Linq
	{
		[Address(RVA = "0x2DC180", Offset = "0x2DB380", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(LinqEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
		[Token(Token = "0x600037D")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000031")]
	public abstract JSONNodeType Tag
	{
		[Token(Token = "0x6000362")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000034")]
	public override string Value
	{
		[Address(RVA = "0x2DC1E0", Offset = "0x2DB3E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000367")]
		 get { } //Length: 44
		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000368")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000041")]
	public ValueEnumerator Values
	{
		[Address(RVA = "0x2DC120", Offset = "0x2DB320", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600037F")]
		 get { } //Length: 93
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003C0")]
	protected JSONNode() { }

	[Address(RVA = "0x2D89F0", Offset = "0x2D7BF0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000373")]
	public override void Add(JSONNode aItem) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000372")]
	public override void Add(string aKey, JSONNode aItem) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000397")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2D8A60", Offset = "0x2D7C60", Length = "0x350")]
	[CalledBy(Type = typeof(JSONObject), Member = "WriteToStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(JSONTextMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONString), Member = "WriteToStringBuilder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(int), typeof(JSONTextMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Capacity", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600039A")]
	internal static string Escape(string aText) { }

	[Address(RVA = "0x2DBD90", Offset = "0x2DAF90", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000388")]
	public override JSONArray get_AsArray() { }

	[Address(RVA = "0x2DBE00", Offset = "0x2DB000", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000386")]
	public override bool get_AsBool() { }

	[Address(RVA = "0x2DBE90", Offset = "0x2DB090", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000380")]
	public override double get_AsDouble() { }

	[Address(RVA = "0x2DBEF0", Offset = "0x2DB0F0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000384")]
	public override float get_AsFloat() { }

	[Address(RVA = "0x2DBF10", Offset = "0x2DB110", Length = "0x20")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000382")]
	public override int get_AsInt() { }

	[Address(RVA = "0x2DBF30", Offset = "0x2DB130", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000389")]
	public override JSONObject get_AsObject() { }

	[Address(RVA = "0x2DBFA0", Offset = "0x2DB1A0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<get_Children>d__39))]
	[Token(Token = "0x6000377")]
	public override IEnumerable<JSONNode> get_Children() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000369")]
	public override int get_Count() { }

	[Address(RVA = "0x2DBFF0", Offset = "0x2DB1F0", Length = "0x70")]
	[CalledBy(Type = typeof(<get_DeepChildren>d__41), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<get_DeepChildren>d__41))]
	[Token(Token = "0x6000378")]
	public IEnumerable<JSONNode> get_DeepChildren() { }

	[Address(RVA = "0x2DC070", Offset = "0x2DB270", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000399")]
	internal static StringBuilder get_EscapeBuilder() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000370")]
	public override bool get_Inline() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036E")]
	public override bool get_IsArray() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036C")]
	public override bool get_IsBoolean() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036D")]
	public override bool get_IsNull() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036A")]
	public override bool get_IsNumber() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036F")]
	public override bool get_IsObject() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036B")]
	public override bool get_IsString() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000365")]
	public override JSONNode get_Item(string aKey) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000363")]
	public override JSONNode get_Item(int aIndex) { }

	[Address(RVA = "0x2DC120", Offset = "0x2DB320", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600037E")]
	public KeyEnumerator get_Keys() { }

	[Address(RVA = "0x2DC180", Offset = "0x2DB380", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LinqEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
	[Token(Token = "0x600037D")]
	public IEnumerable<KeyValuePair`2<String, JSONNode>> get_Linq() { }

	[Token(Token = "0x6000362")]
	public abstract JSONNodeType get_Tag() { }

	[Address(RVA = "0x2DC1E0", Offset = "0x2DB3E0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000367")]
	public override string get_Value() { }

	[Address(RVA = "0x2DC120", Offset = "0x2DB320", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600037F")]
	public ValueEnumerator get_Values() { }

	[Address(RVA = "0x2D8DD0", Offset = "0x2D7FD0", Length = "0x78")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(JSONNode))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(JSONObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JSONArray), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600039D")]
	private static JSONNode GetContainer(JSONContainerType aType) { }

	[Token(Token = "0x600037C")]
	public abstract Enumerator GetEnumerator() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000398")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2DC210", Offset = "0x2DB410", Length = "0x184")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JSONObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONObject), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleJSON.JSONObject+<>c__DisplayClass21_0", Member = "<Remove>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.KeyValuePair`2<System.String, SimpleJSON.JSONNode>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JSONArray), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONArray), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONNode), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<CheckToken>d__50", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "PurchasesService+<ShowPurchaseModal>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JSONObject), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000395")]
	public static bool op_Equality(JSONNode a, object b) { }

	[Address(RVA = "0x2DC430", Offset = "0x2DB630", Length = "0x1C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONContainerType)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x600039E")]
	public static JSONNode op_Implicit(Vector2 aVec) { }

	[Address(RVA = "0x2DCCA0", Offset = "0x2DBEA0", Length = "0x39")]
	[CalledBy(Type = "Polytoria.Networking.PTNetworkManager+<HeartbeatLoop>d__33", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublish>d__74", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadStarterPlaces>d__68", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000394")]
	public static JSONNode op_Implicit(KeyValuePair<String, JSONNode> aKeyValue) { }

	[Address(RVA = "0x2DC660", Offset = "0x2DB860", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONContainerType)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(JSONNode), Member = "WriteVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600039F")]
	public static JSONNode op_Implicit(Vector3 aVec) { }

	[Address(RVA = "0x2DC9F0", Offset = "0x2DBBF0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONContainerType)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(JSONNode), Member = "WriteVector4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A0")]
	public static JSONNode op_Implicit(Vector4 aVec) { }

	[Address(RVA = "0x2DCB20", Offset = "0x2DBD20", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONContainerType)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(JSONNode), Member = "WriteQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A1")]
	public static JSONNode op_Implicit(Quaternion aRot) { }

	[Address(RVA = "0x2DCD40", Offset = "0x2DBF40", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONContainerType)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(JSONNode), Member = "WriteRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A2")]
	public static JSONNode op_Implicit(Rect aRect) { }

	[Address(RVA = "0x2DCC30", Offset = "0x2DBE30", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONContainerType)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(JSONNode), Member = "WriteRectOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A3")]
	public static JSONNode op_Implicit(RectOffset aRect) { }

	[Address(RVA = "0x2DC780", Offset = "0x2DB980", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONNode), Member = "ReadVector2", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A4")]
	public static Vector2 op_Implicit(JSONNode aNode) { }

	[Address(RVA = "0x2DC3A0", Offset = "0x2DB5A0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A5")]
	public static Vector3 op_Implicit(JSONNode aNode) { }

	[Address(RVA = "0x2DC970", Offset = "0x2DBB70", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "ReadVector4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A6")]
	public static Vector4 op_Implicit(JSONNode aNode) { }

	[Address(RVA = "0x2DCDC0", Offset = "0x2DBFC0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A7")]
	public static Quaternion op_Implicit(JSONNode aNode) { }

	[Address(RVA = "0x2DCBA0", Offset = "0x2DBDA0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONNode), Member = "ReadRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A8")]
	public static Rect op_Implicit(JSONNode aNode) { }

	[Address(RVA = "0x2DC900", Offset = "0x2DBB00", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(JSONNode), Member = "ReadRectOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(RectOffset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003A9")]
	public static RectOffset op_Implicit(JSONNode aNode) { }

	[Address(RVA = "0x2DC730", Offset = "0x2DB930", Length = "0x45")]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<CheckOwnsItemFromAPI>d__206", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<LoadMetadata>d__205", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000393")]
	public static bool op_Implicit(JSONNode d) { }

	[Address(RVA = "0x2DCCE0", Offset = "0x2DBEE0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000392")]
	public static JSONNode op_Implicit(bool b) { }

	[Address(RVA = "0x2DC8B0", Offset = "0x2DBAB0", Length = "0x45")]
	[CalledBy(Type = "PurchasesService+<ShowPurchaseModal>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<>c__DisplayClass22_0", Member = "<DoReloadToolbox>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<>c__DisplayClass22_0", Member = "<DoReloadToolbox>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<>c__DisplayClass68_0", Member = "<LoadStarterPlaces>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<>c__DisplayClass68_1", Member = "<LoadStarterPlaces>b__1", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<>c__DisplayClass76_0", Member = "<SetPublishModalSelectedGame>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<CheckToken>d__50", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000391")]
	public static int op_Implicit(JSONNode d) { }

	[Address(RVA = "0x2DC7A0", Offset = "0x2DB9A0", Length = "0x58")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<CheckToken>d__50", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(JSONNumber), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000390")]
	public static JSONNode op_Implicit(int n) { }

	[Address(RVA = "0x2DC800", Offset = "0x2DBA00", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600038F")]
	public static float op_Implicit(JSONNode d) { }

	[Address(RVA = "0x2DC600", Offset = "0x2DB800", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(JSONNumber), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600038E")]
	public static JSONNode op_Implicit(float n) { }

	[Address(RVA = "0x2DCBE0", Offset = "0x2DBDE0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600038D")]
	public static double op_Implicit(JSONNode d) { }

	[Address(RVA = "0x2DCA70", Offset = "0x2DBC70", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(JSONNumber), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Token(Token = "0x600038C")]
	public static JSONNode op_Implicit(double n) { }

	[Address(RVA = "0x2DCAD0", Offset = "0x2DBCD0", Length = "0x45")]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<LoadThumbnail>d__23", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SetPublishModalSelectedGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadStarterPlaces>d__68", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublishModel>d__62", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<DoPublish>d__74", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadThumbnail>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<DoReloadToolbox>d__22", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.AppearanceLoaderBase+<ProcessAppearance>d__57", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.AchievementService+<DoHasAchievement>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.AchievementService+<DoAward>d__11", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<LoadMetadata>d__205", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator+<ValidateToken>d__5", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "PurchasesService+<ShowPurchaseModal>d__13", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ToolboxController+<>c__DisplayClass22_0", Member = "<DoReloadToolbox>b__2", ReturnType = typeof(void))]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600038B")]
	public static string op_Implicit(JSONNode d) { }

	[Address(RVA = "0x2DC850", Offset = "0x2DBA50", Length = "0x54")]
	[CalledBy(Type = "Polytoria.Controllers.NetworkController+<StartClient>d__8", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyEnumerator), Member = "get_Current", ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600038A")]
	public static JSONNode op_Implicit(string s) { }

	[Address(RVA = "0x2DCE40", Offset = "0x2DC040", Length = "0x13")]
	[CalledBy(Type = "PurchasesService+<DoProcessPurchase>d__18", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<CheckToken>d__50", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SetPublishModalSelectedGame", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LinqEnumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LinqEnumerator), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONString), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(JSONNumber), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000396")]
	public static bool op_Inequality(JSONNode a, object b) { }

	[Address(RVA = "0x2D90B0", Offset = "0x2D82B0", Length = "0x66B")]
	[CalledBy(Type = typeof(JSON), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(JSONArray), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(JSONNode), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(JSONObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600039C")]
	public static JSONNode Parse(string aJSON) { }

	[Address(RVA = "0x2D8E60", Offset = "0x2D8060", Length = "0x241")]
	[CalledBy(Type = typeof(JSONNode), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(JSONNumber), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600039B")]
	private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted) { }

	[Address(RVA = "0x2D9720", Offset = "0x2D8920", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60003BE")]
	public Matrix4x4 ReadMatrix() { }

	[Address(RVA = "0x2D9890", Offset = "0x2D8A90", Length = "0x2B3")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = typeof(JSONNode), Member = "ReadQuaternion", ReturnType = typeof(Quaternion))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 17)]
	[Token(Token = "0x60003B5")]
	public Quaternion ReadQuaternion(Quaternion aDefault) { }

	[Address(RVA = "0x2D9820", Offset = "0x2D8A20", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "ReadQuaternion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x60003B6")]
	public Quaternion ReadQuaternion() { }

	[Address(RVA = "0x2D9EC0", Offset = "0x2D90C0", Length = "0x2B3")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = typeof(JSONNode), Member = "ReadRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 17)]
	[Token(Token = "0x60003B8")]
	public Rect ReadRect(Rect aDefault) { }

	[Address(RVA = "0x2DA180", Offset = "0x2D9380", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(JSONNode), Member = "ReadRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(Rect))]
	[Token(Token = "0x60003B9")]
	public Rect ReadRect() { }

	[Address(RVA = "0x2D9BB0", Offset = "0x2D8DB0", Length = "0x300")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(RectOffset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 15)]
	[Token(Token = "0x60003BB")]
	public RectOffset ReadRectOffset(RectOffset aDefault) { }

	[Address(RVA = "0x2D9B50", Offset = "0x2D8D50", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RectOffset), Member = ".ctor", ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60003BC")]
	public RectOffset ReadRectOffset() { }

	[Address(RVA = "0x2DA1C0", Offset = "0x2D93C0", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60003AB")]
	public Vector2 ReadVector2(string aXName, string aYName) { }

	[Address(RVA = "0x2DA470", Offset = "0x2D9670", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x60003AA")]
	public Vector2 ReadVector2(Vector2 aDefault) { }

	[Address(RVA = "0x2DA2D0", Offset = "0x2D94D0", Length = "0x194")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 9)]
	[Token(Token = "0x60003AC")]
	public Vector2 ReadVector2() { }

	[Address(RVA = "0x2DA960", Offset = "0x2D9B60", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "ReadVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60003B0")]
	public Vector3 ReadVector3() { }

	[Address(RVA = "0x2DA7F0", Offset = "0x2D99F0", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x60003AF")]
	public Vector3 ReadVector3(string aXName, string aYName, string aZName) { }

	[Address(RVA = "0x2DA5D0", Offset = "0x2D97D0", Length = "0x219")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(JSONNode), Member = "ReadVector3", ReturnType = typeof(Vector3))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 13)]
	[Token(Token = "0x60003AE")]
	public Vector3 ReadVector3(Vector3 aDefault) { }

	[Address(RVA = "0x2DACA0", Offset = "0x2D9EA0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "ReadVector4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(Vector4))]
	[Token(Token = "0x60003B3")]
	public Vector4 ReadVector4() { }

	[Address(RVA = "0x2DA9E0", Offset = "0x2D9BE0", Length = "0x2B3")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(JSONNode), Member = "ReadVector4", ReturnType = typeof(Vector4))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 17)]
	[Token(Token = "0x60003B2")]
	public Vector4 ReadVector4(Vector4 aDefault) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000375")]
	public override JSONNode Remove(int aIndex) { }

	[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000376")]
	public override JSONNode Remove(JSONNode aNode) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000374")]
	public override JSONNode Remove(string aKey) { }

	[Address(RVA = "0x2DCE60", Offset = "0x2DC060", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000387")]
	public override void set_AsBool(bool value) { }

	[Address(RVA = "0x2DCEE0", Offset = "0x2DC0E0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000381")]
	public override void set_AsDouble(double value) { }

	[Address(RVA = "0x2DCF20", Offset = "0x2DC120", Length = "0x18")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000385")]
	public override void set_AsFloat(float value) { }

	[Address(RVA = "0x2DCF40", Offset = "0x2DC140", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000383")]
	public override void set_AsInt(int value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000371")]
	public override void set_Inline(bool value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000366")]
	public override void set_Item(string aKey, JSONNode value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000364")]
	public override void set_Item(int aIndex, JSONNode value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000368")]
	public override void set_Value(string value) { }

	[Address(RVA = "0x2DADD0", Offset = "0x2D9FD0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600037A")]
	public override string ToString(int aIndent) { }

	[Address(RVA = "0x2DAD30", Offset = "0x2D9F30", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000379")]
	public virtual string ToString() { }

	[Address(RVA = "0x2DAE80", Offset = "0x2DA080", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60003BF")]
	public JSONNode WriteMatrix(Matrix4x4 aMatrix) { }

	[Address(RVA = "0x2DAF40", Offset = "0x2DA140", Length = "0x29D")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(JSONNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 19)]
	[Token(Token = "0x60003B7")]
	public JSONNode WriteQuaternion(Quaternion aRot) { }

	[Address(RVA = "0x2DB4F0", Offset = "0x2DA6F0", Length = "0x29D")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(JSONNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 19)]
	[Token(Token = "0x60003BA")]
	public JSONNode WriteRect(Rect aRect) { }

	[Address(RVA = "0x2DB1E0", Offset = "0x2DA3E0", Length = "0x308")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectOffset)}, ReturnType = typeof(JSONNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_right", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_bottom", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 19)]
	[Token(Token = "0x60003BD")]
	public JSONNode WriteRectOffset(RectOffset aRect) { }

	[Token(Token = "0x600037B")]
	internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

	[Address(RVA = "0x2DB790", Offset = "0x2DA990", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x60003AD")]
	public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y") { }

	[Address(RVA = "0x2DB900", Offset = "0x2DAB00", Length = "0x1EA")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(JSONNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 15)]
	[Token(Token = "0x60003B1")]
	public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z") { }

	[Address(RVA = "0x2DBAF0", Offset = "0x2DACF0", Length = "0x29D")]
	[CalledBy(Type = typeof(JSONNode), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(JSONNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 19)]
	[Token(Token = "0x60003B4")]
	public JSONNode WriteVector4(Vector4 aVec) { }

}

