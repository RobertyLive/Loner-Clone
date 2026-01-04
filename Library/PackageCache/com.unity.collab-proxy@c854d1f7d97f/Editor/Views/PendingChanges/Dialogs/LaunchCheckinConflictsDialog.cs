g on audio clip.");
        public static readonly GUIContent SnapToFrameLabel = L10n.TextContent("Snap To Frame", "Enable Snap to Frame to manipulate clips and align them on frames.");
        public static readonly GUIContent EdgeSnapLabel = L10n.TextContent("Edge Snap", "Enable the ability to snap clips on the edge of another clip.");
        public static readonly GUIContent PlaybackScrollModeLabel = L10n.TextContent("Playback Scrolling Mode", "Define scrolling behavior during playback.");
        public static readonly GUIContent EditorSettingLabel = L10n.TextContent("Timeline Editor Settings", "");
#if TIMELINE_FRAMEACCURATE
        public static readonly GUIContent PlaybackLockedToFrame = L10n.TextContent("Playback Locked To Frame", "Enable Frame Accurate Preview.");
#endif
    }

    public TimelinePreferencesProvider(string path, SettingsScope scopes, IEnumerable<string> keywords = null)
        : base(path, scopes, keywords)
    {
    }

    public override void OnActivate(string searchContext, VisualElement rootElement)
    {
        TimelinePreferences.instance.Save();
        m_SerializedObject = TimelinePreferences