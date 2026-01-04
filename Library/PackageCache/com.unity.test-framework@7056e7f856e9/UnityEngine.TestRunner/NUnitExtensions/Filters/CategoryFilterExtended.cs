ameter="JoinResult" ItemName="_JoinedResolvedCompileFileDefinitions" />
    </JoinItems>

    <ItemGroup>
      <Reference Remove="@(_JoinedResolvedCompileFileDefinitions)" />
      <Reference Include="@(_JoinedResolvedCompileFileDefinitions)" />
    </ItemGroup>

    <ItemGroup>
      <ResolvedCompileFileDefinitionsToAdd Include="@(ResolvedCompileFileDefinitions)" />
      <ResolvedCompileFileDefinitionsToAdd Remove="%(_JoinedResolvedCompileFileDefinitions.HintPath)" />

      <!-- Add the references we computed -->
      <Reference Include="@(ResolvedCompileFileDefinitionsToAdd)" />
    </ItemGroup>

  </Target>

  <!--
    ============================================================
    ProjectReference Targets: Include transitive project references before
                              Resolv