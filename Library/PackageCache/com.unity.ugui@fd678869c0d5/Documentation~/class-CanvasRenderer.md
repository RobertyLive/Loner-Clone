ection
            .OfType<T>()
            .Where(i => !i.MetadataProperties.Any(p => p.Name == ExternalTypeNameAttributeName))
            .OrderBy(i => i.Name);
    }

    public IEnumerable<string> GetAllGlobalItems(IEnumerable<GlobalItem> itemCollection)
    {
        return itemCollection
            .Where(i => i is EntityType || i is ComplexType || i is EntityContainer || IsEnumType(i))
            .Select(g => GetGlobalItemName(g));
    }

    public string GetGlobalItemName(GlobalItem item)
    {
        if (item is EdmType)
        {
            return ((EdmType)item).Name;
        }
        else
        {
            return ((EntityContainer)item).Name;
        }
    }

    public IEnumer