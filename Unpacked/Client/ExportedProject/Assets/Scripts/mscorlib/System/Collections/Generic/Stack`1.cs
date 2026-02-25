namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(StackDebugView`1))]
[Token(Token = "0x20005F1")]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
public class Stack : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[Token(Token = "0x20005F2")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001883")]
		private readonly Stack<T> _stack; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001884")]
		private readonly int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001885")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001886")]
		private T _currentElement; //Field offset: 0x0

		[Token(Token = "0x170006DB")]
		public override T Current
		{
			[Address(RVA = "0xB08770", Offset = "0xB07970", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800839F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002BB0")]
			 get { } //Length: 68
		}

		[Token(Token = "0x170006DC")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xB05BF0", Offset = "0xB04DF0", Length = "0x99")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800839F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6002BB2")]
			private get { } //Length: 153
		}

		[Address(RVA = "0xB07D30", Offset = "0xB06F30", Length = "0x41")]
		[CalledBy(Type = typeof(Stack`1), Member = "System.Collections.Generic.IEnumerable<T>.GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
		[CalledBy(Type = typeof(Stack`1), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BAD")]
		internal Enumerator(Stack<T> stack) { }

		[Address(RVA = "0xAFF9C0", Offset = "0xAFEBC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BAE")]
		public override void Dispose() { }

		[Address(RVA = "0xB08770", Offset = "0xB07970", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800839F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BB0")]
		public override T get_Current() { }

		[Address(RVA = "0xB03D70", Offset = "0xB02F70", Length = "0x126")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BAF")]
		public override bool MoveNext() { }

		[Address(RVA = "0xB05BF0", Offset = "0xB04DF0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BA0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800839F0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BB2")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xB052A0", Offset = "0xB044A0", Length = "0x79")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BB3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0xB07100", Offset = "0xB06300", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BB1")]
		private void ThrowEnumerationNotStartedOrEnded() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400187F")]
	private T[] _array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001880")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001881")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001882")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x170006D9")]
	public override int Count
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BA0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006DA")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xF63A40", Offset = "0xF62C40", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002BA1")]
		private get { } //Length: 104
	}

	[Address(RVA = "0xF64050", Offset = "0xF63250", Length = "0x1BB")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B9E")]
	public Stack`1() { }

	[Address(RVA = "0xEB9D00", Offset = "0xEB8F00", Length = "0xE4")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B9F")]
	public Stack`1(int capacity) { }

	[Address(RVA = "0xF628F0", Offset = "0xF61AF0", Length = "0xD")]
	[CalledBy(Type = "UnityEngine.UIElements.TreeDataController`1", Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", "System.Func`2<HierarchyNode, HierarchyNode>", "System.Action`2<Int32, HierarchyNode>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.DrawParams", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryProcessor", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.Entry", "UnityEngine.UIElements.UIR.RenderTreeManager", "UnityEngine.UIElements.UIR.RenderData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher", Member = "Match", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression", "System.Collections.Generic.List`1<StylePropertyValue>"}, ReturnType = "UnityEngine.UIElements.StyleSheets.MatchResult")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA2")]
	public void Clear() { }

	[Address(RVA = "0xF62B30", Offset = "0xF61D30", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "LastIndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA3")]
	public bool Contains(T item) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA0")]
	public override int get_Count() { }

	[Address(RVA = "0xF62C80", Offset = "0xF61E80", Length = "0x6D")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ProcessCombinatorStack", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_ObjectPool`1", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_ListPool`1", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.DtdParser", Member = "ParseElementOnlyContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.ParticleContentValidator", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "NeedToPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Stack`1<String>", "UnityEngine.ExpressionEvaluator+Operator"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "InfixToRPN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]"}, ReturnType = "System.String[]")]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "EvaluateDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]", typeof(Double&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "SimpleJSON.JSONNode", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "SimpleJSON.JSONNode")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LightCompiler", Member = "CompileThrowUnaryExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.Expression", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ObjectListPool`1", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "UnityEngine.UIElements.IUIElementsUtility.TakeCapture", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleVariableResolver", Member = "PopContext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ObjectPool`1", Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.AncestorFilter", Member = "PopElement", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", "UnityEngine.Rect", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F82E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA7")]
	public T Peek() { }

	[Address(RVA = "0xF62DF0", Offset = "0xF61FF0", Length = "0x79")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeDataController`1", Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", "System.Func`2<HierarchyNode, HierarchyNode>", "System.Action`2<Int32, HierarchyNode>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.AncestorFilter", Member = "PopElement", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextureRegistry", Member = "AllocAndAcquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Texture", typeof(bool)}, ReturnType = "UnityEngine.UIElements.TextureId")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "PopScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "RestoreContext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "DropContext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ProcessCombinatorStack", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.GUIEx", Member = "PopColor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F82E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA8")]
	public T Pop() { }

	[Address(RVA = "0xF634C0", Offset = "0xF626C0", Length = "0x5D")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "MatchCombinator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseDataType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseExpression", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "MatchMany", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "MatchOr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.Expression"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.GUIEx", Member = "PushColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Color"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.BaseStyleMatcher", Member = "SaveContext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPreProcessor", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "PushScissor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", "UnityEngine.Rect", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.DrawParams", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.AncestorFilter", Member = "PushElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.AncestorFilter", Member = "AddHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeDataController`1", Member = "ConvertTreeViewItemDataToHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TreeViewItemData`1<T>>", "System.Func`2<HierarchyNode, HierarchyNode>", "System.Action`2<Int32, HierarchyNode>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseNonTerminalValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxParser", Member = "ParseProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer"}, ReturnType = "UnityEngine.UIElements.StyleSheets.Syntax.Expression")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Stack`1), Member = "PushWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BAA")]
	public void Push(T item) { }

	[Address(RVA = "0xF63210", Offset = "0xF62410", Length = "0x80")]
	[CalledBy(Type = typeof(Stack`1), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BAB")]
	private void PushWithResize(T item) { }

	[Address(RVA = "0xF63600", Offset = "0xF62800", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Stack`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA5")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xF63790", Offset = "0xF62990", Length = "0x2A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA4")]
	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0xF63A40", Offset = "0xF62C40", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA1")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xF63600", Offset = "0xF62800", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Stack`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA6")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xF63DC0", Offset = "0xF62FC0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BAC")]
	private void ThrowForEmptyStack() { }

	[Address(RVA = "0xF63FF0", Offset = "0xF631F0", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPreProcessor", Member = "PreProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.Entry"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.EntryPreProcessor", Member = "DoEvaluate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.Entry"}, ReturnType = typeof(void))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002BA9")]
	public bool TryPop(out T result) { }

}

