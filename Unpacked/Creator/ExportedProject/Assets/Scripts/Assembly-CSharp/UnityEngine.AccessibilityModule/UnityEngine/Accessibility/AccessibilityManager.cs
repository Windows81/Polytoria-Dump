namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Native/AccessibilityManager.h")]
[Token(Token = "0x2000003")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.AccessibilityModule"})]
internal static class AccessibilityManager
{
	[Token(Token = "0x2000005")]
	private sealed class ExclusiveLock : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000010")]
		private bool m_Disposed; //Field offset: 0x10

		[Address(RVA = "0x18FEF40", Offset = "0x18FE140", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000028")]
		public ExclusiveLock() { }

		[Address(RVA = "0x18FED70", Offset = "0x18FDF70", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002B")]
		public override void Dispose() { }

		[Address(RVA = "0x18FEE20", Offset = "0x18FE020", Length = "0xAD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000029")]
		protected virtual void Finalize() { }

		[Address(RVA = "0x18FEED0", Offset = "0x18FE0D0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600002A")]
		private void InternalDispose() { }

	}

	[Token(Token = "0x2000004")]
	internal struct NotificationContext
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000006")]
		private AccessibilityNotification <notification>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000007")]
		private bool <isScreenReaderEnabled>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000008")]
		private string <announcement>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000009")]
		private bool <wasAnnouncementSuccessful>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000A")]
		private AccessibilityNode <currentNode>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400000B")]
		private AccessibilityNode <nextNode>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400000C")]
		private float <fontScale>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400000D")]
		private bool <isBoldTextEnabled>k__BackingField; //Field offset: 0x2C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x2D")]
		[Token(Token = "0x400000E")]
		private bool <isClosedCaptioningEnabled>k__BackingField; //Field offset: 0x2D
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000F")]
		private AccessibilityNotificationContext <nativeContext>k__BackingField; //Field offset: 0x30

		[Token(Token = "0x17000004")]
		public string announcement
		{
			[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600001B")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000006")]
		public AccessibilityNode currentNode
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x600001D")]
			 get { } //Length: 5
			[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600001E")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000008")]
		public float fontScale
		{
			[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000020")]
			 get { } //Length: 6
			[Address(RVA = "0x18FF160", Offset = "0x18FE360", Length = "0x6")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[Token(Token = "0x6000021")]
			 set { } //Length: 6
		}

		[Token(Token = "0x17000009")]
		public bool isBoldTextEnabled
		{
			[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000022")]
			 get { } //Length: 5
			[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000023")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700000A")]
		public bool isClosedCaptioningEnabled
		{
			[Address(RVA = "0x3BAA10", Offset = "0x3B9C10", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000024")]
			 get { } //Length: 5
			[Address(RVA = "0x3BAA30", Offset = "0x3B9C30", Length = "0x4")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000025")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000003")]
		public bool isScreenReaderEnabled
		{
			[Address(RVA = "0xCE3800", Offset = "0xCE2A00", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000019")]
			 get { } //Length: 5
			[Address(RVA = "0x18FCBD0", Offset = "0x18FBDD0", Length = "0x4")]
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600001A")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700000B")]
		public AccessibilityNotificationContext nativeContext
		{
			[Address(RVA = "0x18FF170", Offset = "0x18FE370", Length = "0x1A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[Token(Token = "0x6000026")]
			 set { } //Length: 26
		}

		[Token(Token = "0x17000007")]
		public AccessibilityNode nextNode
		{
			[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
			[CallerCount(Count = 10)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600001F")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000002")]
		public AccessibilityNotification notification
		{
			[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
			[CallerCount(Count = 129)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[IsReadOnly]
			[Token(Token = "0x6000017")]
			 get { } //Length: 3
			[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
			[CallerCount(Count = 11)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000018")]
			 set { } //Length: 3
		}

		[Token(Token = "0x17000005")]
		public bool wasAnnouncementSuccessful
		{
			[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
			[CallerCount(Count = 1)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600001C")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x18FEFB0", Offset = "0x18FE1B0", Length = "0x1A6")]
		[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_OnAccessibilityNotificationReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNotificationContext&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(AccessibilityHierarchy), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000027")]
		public NotificationContext(ref AccessibilityNotificationContext nativeNotification) { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x600001D")]
		public AccessibilityNode get_currentNode() { }

		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000020")]
		public float get_fontScale() { }

		[Address(RVA = "0x3BAA00", Offset = "0x3B9C00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000022")]
		public bool get_isBoldTextEnabled() { }

		[Address(RVA = "0x3BAA10", Offset = "0x3B9C10", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000024")]
		public bool get_isClosedCaptioningEnabled() { }

		[Address(RVA = "0xCE3800", Offset = "0xCE2A00", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000019")]
		public bool get_isScreenReaderEnabled() { }

		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000017")]
		public AccessibilityNotification get_notification() { }

		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600001B")]
		public void set_announcement(string value) { }

		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600001E")]
		public void set_currentNode(AccessibilityNode value) { }

		[Address(RVA = "0x18FF160", Offset = "0x18FE360", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000021")]
		public void set_fontScale(float value) { }

		[Address(RVA = "0x3BAA20", Offset = "0x3B9C20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000023")]
		public void set_isBoldTextEnabled(bool value) { }

		[Address(RVA = "0x3BAA30", Offset = "0x3B9C30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000025")]
		public void set_isClosedCaptioningEnabled(bool value) { }

		[Address(RVA = "0x18FCBD0", Offset = "0x18FBDD0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600001A")]
		public void set_isScreenReaderEnabled(bool value) { }

		[Address(RVA = "0x18FF170", Offset = "0x18FE370", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000026")]
		public void set_nativeContext(AccessibilityNotificationContext value) { }

		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600001F")]
		public void set_nextNode(AccessibilityNode value) { }

		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000018")]
		public void set_notification(AccessibilityNotification value) { }

		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		public void set_wasAnnouncementSuccessful(bool value) { }

	}

	[Token(Token = "0x4000003")]
	internal static Queue<NotificationContext> asyncNotificationContexts; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000004")]
	private static Action<Boolean> screenReaderStatusChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000005")]
	private static Action<AccessibilityNode> nodeFocusChanged; //Field offset: 0x10

	[Token(Token = "0x14000002")]
	public static event Action<AccessibilityNode> nodeFocusChanged
	{
		[Address(RVA = "0x18FC790", Offset = "0x18FB990", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		 add { } //Length: 261
		[Address(RVA = "0x18FC9B0", Offset = "0x18FBBB0", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000009")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x14000001")]
	public static event Action<Boolean> screenReaderStatusChanged
	{
		[Address(RVA = "0x18FC8A0", Offset = "0x18FBAA0", Length = "0x105")]
		[CalledBy(Type = typeof(AssistiveSupport), Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ServiceManager), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		 add { } //Length: 261
		[Address(RVA = "0x18FCAC0", Offset = "0x18FBCC0", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		 remove { } //Length: 261
	}

	[Address(RVA = "0x18FC700", Offset = "0x18FB900", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	private static AccessibilityManager() { }

	[Address(RVA = "0x18FC790", Offset = "0x18FB990", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	public static void add_nodeFocusChanged(Action<AccessibilityNode> value) { }

	[Address(RVA = "0x18FC8A0", Offset = "0x18FBAA0", Length = "0x105")]
	[CalledBy(Type = typeof(AssistiveSupport), Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ServiceManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	public static void add_screenReaderStatusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x18FB9C0", Offset = "0x18FABC0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	internal static IDisposable GetExclusiveLock() { }

	[Address(RVA = "0x18FBB40", Offset = "0x18FAD40", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "TryGetNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AccessibilityNode&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AccessibilityNode), Member = "GetNodeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNodeData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RequiredByNativeCode]
	[Token(Token = "0x600000F")]
	internal static bool Internal_GetNode(int id, ref AccessibilityNodeData nodeData) { }

	[Address(RVA = "0x18FBA60", Offset = "0x18FAC60", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AccessibilityHierarchy), Member = "<TryGetNodeAt>g__FindNodeContainingPoint|27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<UnityEngine.Accessibility.AccessibilityNode>), typeof(Vector2)}, ReturnType = typeof(AccessibilityNode))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000010")]
	internal static int Internal_GetNodeIdAt(float x, float y) { }

	[Address(RVA = "0x18FBC20", Offset = "0x18FAE20", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "GetService", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection&"}, ReturnType = "UnityEngine.Pool.PooledObject`1<TCollection>")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(PooledObject`1), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x600000E")]
	internal static Int32[] Internal_GetRootNodeIds() { }

	[Address(RVA = "0x18FBEB0", Offset = "0x18FB0B0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AssistiveSupport), Member = "Initialize", ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x600000C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.AccessibilityModule"})]
	internal static void Internal_Initialize() { }

	[Address(RVA = "0x18FBEF0", Offset = "0x18FB0F0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NotificationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNotificationContext&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AccessibilityManager), Member = "QueueNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000011")]
	internal static void Internal_OnAccessibilityNotificationReceived(ref AccessibilityNotificationContext context) { }

	[Address(RVA = "0x18FBFC0", Offset = "0x18FB1C0", Length = "0x318")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Queue`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x600000D")]
	private static void Internal_Update() { }

	[Address(RVA = "0x18FC4C0", Offset = "0x18FB6C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	internal static bool IsScreenReaderEnabled() { }

	[Address(RVA = "0x18FC4F0", Offset = "0x18FB6F0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000014")]
	private static void Lock() { }

	[Address(RVA = "0x18FC520", Offset = "0x18FB720", Length = "0x16D")]
	[CalledBy(Type = typeof(AccessibilityManager), Member = "Internal_OnAccessibilityNotificationReceived", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AccessibilityNotificationContext&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNodeManager), Member = "Internal_InvokeFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilitySettings), Member = "Internal_OnFontScaleChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilitySettings), Member = "Internal_OnBoldTextStatusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilitySettings), Member = "Internal_OnClosedCaptioningStatusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AccessibilityNode), Member = "NotifyFocusChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<UnityEngine.Accessibility.AccessibilityManager+NotificationContext>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NotificationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000012")]
	internal static void QueueNotification(NotificationContext notification) { }

	[Address(RVA = "0x18FC9B0", Offset = "0x18FBBB0", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000009")]
	public static void remove_nodeFocusChanged(Action<AccessibilityNode> value) { }

	[Address(RVA = "0x18FCAC0", Offset = "0x18FBCC0", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	public static void remove_screenReaderStatusChanged(Action<Boolean> value) { }

	[Address(RVA = "0x18FC690", Offset = "0x18FB890", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	internal static void SendAccessibilityNotification(in AccessibilityNotificationContext context) { }

	[Address(RVA = "0x18FC6D0", Offset = "0x18FB8D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6000015")]
	private static void Unlock() { }

}

