namespace Unity.Hierarchy;

[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
[NativeHeader("Modules/HierarchyCore/HierarchyNodeTypeHandlerBaseBindings.h")]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x200000A")]
public abstract class HierarchyNodeTypeHandlerBase
{
	[Token(Token = "0x200000B")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600002C")]
		public static IntPtr ConvertToNative(HierarchyNodeTypeHandlerBase handler) { }

	}

	[Token(Token = "0x200000C")]
	private struct ConstructorScope : IDisposable
	{
		[ThreadStatic]
		[Token(Token = "0x400001B")]
		private static IntPtr m_Ptr; //Field offset: 0x80000000
		[ThreadStatic]
		[Token(Token = "0x400001C")]
		private static Hierarchy m_Hierarchy; //Field offset: 0x80000008
		[ThreadStatic]
		[Token(Token = "0x400001D")]
		private static HierarchyCommandList m_CommandList; //Field offset: 0x80000010

		[Token(Token = "0x17000005")]
		private static HierarchyCommandList CommandList
		{
			[Address(RVA = "0x1995740", Offset = "0x1994940", Length = "0x52")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x600002F")]
			private set { } //Length: 82
		}

		[Token(Token = "0x17000004")]
		private static Hierarchy Hierarchy
		{
			[Address(RVA = "0x19957A0", Offset = "0x19949A0", Length = "0x52")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Token(Token = "0x600002E")]
			private set { } //Length: 82
		}

		[Token(Token = "0x17000003")]
		private static IntPtr Ptr
		{
			[Address(RVA = "0x1995800", Offset = "0x1994A00", Length = "0x3A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
			[Token(Token = "0x600002D")]
			private set { } //Length: 58
		}

		[Address(RVA = "0x1995660", Offset = "0x1994860", Length = "0xDA")]
		[CalledBy(Type = typeof(HierarchyNodeTypeHandlerBase), Member = "CreateNodeTypeHandlerFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000030")]
		public ConstructorScope(IntPtr nativePtr, Hierarchy hierarchy, HierarchyCommandList cmdList) { }

		[Address(RVA = "0x1995590", Offset = "0x1994790", Length = "0xC5")]
		[CalledBy(Type = typeof(HierarchyNodeTypeHandlerBase), Member = "CreateNodeTypeHandlerFromType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type), typeof(IntPtr), typeof(IntPtr)}, ReturnType = typeof(IntPtr))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000031")]
		public override void Dispose() { }

		[Address(RVA = "0x1995740", Offset = "0x1994940", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600002F")]
		private static void set_CommandList(HierarchyCommandList value) { }

		[Address(RVA = "0x19957A0", Offset = "0x19949A0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600002E")]
		private static void set_Hierarchy(Hierarchy value) { }

		[Address(RVA = "0x1995800", Offset = "0x1994A00", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Token(Token = "0x600002D")]
		private static void set_Ptr(IntPtr value) { }

	}

	[Token(Token = "0x400001A")]
	private static readonly Dictionary<Type, Int32> s_NodeTypes; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000017")]
	internal readonly IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000018")]
	private readonly Hierarchy m_Hierarchy; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000019")]
	private readonly HierarchyCommandList m_CommandList; //Field offset: 0x20

	[Address(RVA = "0x1998760", Offset = "0x1997960", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000024")]
	private static HierarchyNodeTypeHandlerBase() { }

	[Address(RVA = "0x19977A0", Offset = "0x19969A0", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::ChangesPending", HasExplicitThis = True, IsThreadSafe = True)]
	[Obsolete("ChangesPending is obsolete, it is replaced by adding commands into the hierarchy node type handler's CommandList.", False)]
	[Token(Token = "0x6000022")]
	protected override bool ChangesPending() { }

	[Address(RVA = "0x1997760", Offset = "0x1996960", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002A")]
	private static bool ChangesPending_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1997830", Offset = "0x1996A30", Length = "0x269")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819954C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181994FE0")]
	[Calls(Type = typeof(ConstructorScope), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Hierarchy), typeof(HierarchyCommandList)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ConstructorScope), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000018")]
	private static IntPtr CreateNodeTypeHandlerFromType(IntPtr nativePtr, Type handlerType, IntPtr hierarchyPtr, IntPtr cmdListPtr) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1997AA0", Offset = "0x1996CA0", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000016")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal static HierarchyNodeTypeHandlerBase FromIntPtr(IntPtr handlePtr) { }

	[Address(RVA = "0x1997BF0", Offset = "0x1996DF0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	[Token(Token = "0x6000012")]
	public override HierarchyNodeFlags GetDefaultNodeFlags(in HierarchyNode node, HierarchyNodeFlags defaultFlags = 0) { }

	[Address(RVA = "0x1997B90", Offset = "0x1996D90", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	private static HierarchyNodeFlags GetDefaultNodeFlags_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	[Address(RVA = "0x1997CF0", Offset = "0x1996EF0", Length = "0x11B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000011")]
	public override string GetNodeTypeName() { }

	[Address(RVA = "0x1997CA0", Offset = "0x1996EA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	private static void GetNodeTypeName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	protected override void Initialize() { }

	[Address(RVA = "0x1997E60", Offset = "0x1997060", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::IntegrateChanges", HasExplicitThis = True, IsThreadSafe = True)]
	[Obsolete("IntegrateChanges is obsolete, it is replaced by adding commands into the hierarchy node type handler's CommandList.", False)]
	[Token(Token = "0x6000023")]
	protected override bool IntegrateChanges(HierarchyCommandList cmdList) { }

	[Address(RVA = "0x1997E10", Offset = "0x1997010", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	private static bool IntegrateChanges_Injected(IntPtr _unity_self, IntPtr cmdList) { }

	[Address(RVA = "0x166E740", Offset = "0x166D940", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000017")]
	internal void Internal_SearchBegin(HierarchySearchQueryDescriptor query) { }

	[Address(RVA = "0x1997F20", Offset = "0x1997120", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001E")]
	private static bool InvokeChangesPending(IntPtr handlePtr) { }

	[Address(RVA = "0x1997F90", Offset = "0x1997190", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001B")]
	private static void InvokeDispose(IntPtr handlePtr) { }

	[Address(RVA = "0x1998030", Offset = "0x1997230", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001D")]
	private static HierarchyNodeFlags InvokeGetDefaultNodeFlags(IntPtr handlePtr, in HierarchyNode node, HierarchyNodeFlags defaultFlags) { }

	[Address(RVA = "0x19980C0", Offset = "0x19972C0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001C")]
	private static string InvokeGetNodeTypeName(IntPtr handlePtr) { }

	[Address(RVA = "0x1998130", Offset = "0x1997330", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001A")]
	private static void InvokeInitialize(IntPtr handlePtr) { }

	[Address(RVA = "0x19981A0", Offset = "0x19973A0", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181994FE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600001F")]
	private static bool InvokeIntegrateChanges(IntPtr handlePtr, IntPtr cmdListPtr) { }

	[Address(RVA = "0x1998230", Offset = "0x1997430", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000021")]
	private static void InvokeSearchEnd(IntPtr handlePtr) { }

	[Address(RVA = "0x19982A0", Offset = "0x19974A0", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181995300")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000020")]
	private static bool InvokeSearchMatch(IntPtr handlePtr, in HierarchyNode node) { }

	[Address(RVA = "0x1998370", Offset = "0x1997570", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::SearchBegin", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000013")]
	protected override void SearchBegin(HierarchySearchQueryDescriptor query) { }

	[Address(RVA = "0x1998320", Offset = "0x1997520", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	private static void SearchBegin_Injected(IntPtr _unity_self, HierarchySearchQueryDescriptor query) { }

	[Address(RVA = "0x1998450", Offset = "0x1997650", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::SearchEnd", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000015")]
	protected override void SearchEnd() { }

	[Address(RVA = "0x1998410", Offset = "0x1997610", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	private static void SearchEnd_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1998530", Offset = "0x1997730", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::SearchMatch", HasExplicitThis = True, IsThreadSafe = True)]
	[Token(Token = "0x6000014")]
	protected override bool SearchMatch(in HierarchyNode node) { }

	[Address(RVA = "0x19984E0", Offset = "0x19976E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	private static bool SearchMatch_Injected(IntPtr _unity_self, in HierarchyNode node) { }

	[Address(RVA = "0x19985D0", Offset = "0x19977D0", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(MethodInfo))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000019")]
	private static bool TryGetStaticNodeType(Type handlerType, out int nodeType) { }

}

