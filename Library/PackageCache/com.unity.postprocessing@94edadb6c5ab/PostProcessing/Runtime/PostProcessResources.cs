a new instance of the <see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> class.</summary>
      <param name="propertyName">The name of the property that changed.</param>
    </member>
    <member name="P:System.ComponentModel.PropertyChangedEventArgs.PropertyName">
      <summary>Gets the name of the property that changed.</summary>
      <returns>The name of the property that changed.</returns>
    </member>
    <member name="T:System.ComponentModel.PropertyChangedEventHandler">
      <summary>Represents the method that will handle the <see cref="E:System.ComponentModel.INotifyPropertyChanged.PropertyChanged" /> event raised when a property is changed on a component.</summary>
      <param name="sender">The source of the event.</param>
      <param name="e">A <see cref="T:System.ComponentModel.PropertyChangedEventArgs" /> that contains the event data.</param>
    </member>
    <member name="T:System.ComponentModel.PropertyChangingEventArgs">
      <summary>Provides data for the <see cref="E:System.ComponentModel.INotifyPropertyChanging.PropertyChanging" /> event.</summary>
    </member>
    <member name="M:System.ComponentModel.PropertyChangingEventArgs.#ctor(System.String)">
      <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.PropertyChangingEventArgs" /> class.</summary>
      <param name="propertyName">The name of the property whose value is changing.</param>
    </member>
    <member name="P:System.ComponentModel.PropertyChangingEventArgs.PropertyName">
      <summary>Gets the name of the property whose value is changing.</summary>
      <returns>The name of the property whose value is changing.</returns>
    </member>
    <member name="T:System.ComponentModel.PropertyChangingEventHandler">
      <summary>Represents the method that will handle the <see cref="E:System.ComponentModel.INotifyPropertyChanging.PropertyChanging" /> event of an <see cref="T:System.ComponentModel.INotifyPropertyChanging" /> interface.</summary>
      <param name="sender">The source of the event.</param>
      <param name="e">A <see cref="T:System.ComponentModel.PropertyChangingEventArgs" /> that contains the event data.</param>
    </member>
    <member name="T:System.ComponentModel.TypeConverterAttribute">
      <summary>Specifies what type to use as a converter for the object this attribute is bound to.</summary>
    </member>
    <member name="F:System.ComponentModel.TypeConverterAttribute.Default">
      <summary>Specifies the type to use as a converter for the object this attribute is bound to.</summary>
    </member>
    <member name="M:System.ComponentModel.TypeConverterAttribute.#ctor">
      <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverterAttribute" /> class with the default type converter, which is an empty string ("").</summary>
    </member>
    <member name="M:System.ComponentModel.TypeConverterAttribute.#ctor(System.String)">
      <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverterAttribute" /> class, using the specified type name as the data converter for the object this attribute is bound to.</summary>
      <param name="typeName">The fully qualified name of the class to use for data conversion for the object this attribute is bound to.</param>
    </member>
    <member name="M:System.ComponentModel.TypeConverterAttribute.#ctor(System.Type)">
      <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeConverterAttribute" /> class, using the specified type as the data converter for the object this attribute is bound to.</summary>
      <param name="type">A <see cref="T:System.Type" /> that represents the type of the converter class to use for data conversion for the object this attribute is bound to.</param>
    </member>
    <member name="M:System.ComponentModel.TypeConverterAttribute.Equals(System.Object)">
      <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.TypeConverterAttribute" />.</summary>
      <param name="obj">The object to test the value equality of.</param>
      <returns>
        <see langword="true" /> if the value of the given object is equal to that of the current <see cref="T:System.ComponentModel.TypeConverterAttribute" />; otherwise, <see langword="false" />.</returns>
    </member>
    <member name="M:System.ComponentModel.TypeConverterAttribute.GetHashCode">
      <summary>Returns the hash code for this instance.</summary>
      <returns>A hash code for the current <see cref="T:System.ComponentModel.TypeConverterAttribute" />.</returns>
    </member>
    <member name="P:System.ComponentModel.TypeConverterAttribute.ConverterTypeName">
      <summary>Gets the fully qualified type name of the <see cref="T:System.Type" /> to use as a converter for the object this attribute is bound to.</summary>
      <returns>The fully qualified type name of the <see cref="T:System.Type" /> to use as a converter for the object this attribute is bound to, or an empty string ("") if none exists. The default value is an empty string ("").</returns>
    </member>
    <member name="T:System.ComponentModel.TypeDescriptionProviderAttribute">
      <summary>Specifies the custom type description provider for a class. This class cannot be inherited.</summary>
    </member>
    <member name="M:System.ComponentModel.TypeDescriptionProviderAttribute.#ctor(System.String)">
      <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeDescriptionProviderAttribute" /> class using the specified type name.</summary>
      <param name="typeName">The qualified name of the type.</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="typeName" /> is <see langword="null" />.</exception>
    </member>
    <member name="M:System.ComponentModel.TypeDescriptionProviderAttribute.#ctor(System.Type)">
      <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.TypeDescriptionProviderAttribute" /> class using the specified type.</summary>
      <param name="type">The type to store in the attribute.</param>
      <exception cref="T:System.ArgumentNullException">
        <paramref name="type" /> is <see langword="null" />.</exception>
    </member>
    <member name="P:System.ComponentModel.TypeDescriptionProviderAttribute.TypeName">
      <summary>Gets the type name for the type description provider.</summary>
      <returns>A <see cref="T:System.String" /> containing the qualified type name for the <see cref="T:System.ComponentModel.TypeDescriptionProvider" />.</returns>
    </member>
    <member name="T:System.Reflection.ICustomTypeProvider">
      <summary>Represents an object that provides a custom type.</summary>
    </member>
    <member name="M:System.Reflection.ICustomTypeProvider.GetCustomType">
      <summary>Gets the custom type provided by this object.</summary>
      <returns>The custom type.</returns>
    </member>
    <member name="T:System.Windows.Input.ICommand">
      <summary>Defines a command.</summary>
    </member>
    <member name="E:System.Windows.Input.ICommand.CanExecuteChanged">
      <summary>Occurs when changes take place that affect whether or not the command should execute.</summary>
    </member>
    <member name="M:System.Windows.Input.ICommand.CanExecute(System.Object)">
      <summary>Determines whether the command can execute in its current state.</summary>
      <param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
      <returns>
        <see langword="true" /> if this command can be executed; otherwise, <see langword="false" />.</returns>
    </member>
    <member name="M:System.Windows.Input.ICommand.Execute(System.Object)">
      <summary>Defines the method to be called when the command is invoked.</summary>
      <param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to <see langword="null" />.</param>
    </member>
    <member name="T:System.Windows.Markup.ValueSerializerAttribute">
      <summary>Identifies the <see cref="T:System.Windows.Markup.ValueSerializer" /> class that a type or property should use when it is serialized.</summary>
    </member>
    <member name="M:System.Windows.Markup.ValueSerializerAttribute.#ctor(System.String)">
      <summary>Initializes a new instance of the <see cref="T:System.Windows.Markup.ValueSerializerAttribute" /> class, using an assembly qualified type name string.</summary>
      <param name="valueSerializerTypeName">The assembly qualified type name string for the <see cref="T:System.Windows.Markup.ValueSerializer" /> class to use.</param>
    </member>
    <member name="M:System.Windows.Markup.ValueSerializerAttribute.#ctor(System.Type)">
      <summary>Initializes a new instance of the <see cref="T:System.Windows.Markup.ValueSerializerAttribute" /> class, using the specified type.</summary>
      <param name="valueSerializerType">A type that represents the type of the <see cref="T:System.Windows.Markup.ValueSerializer" /> class.</param>
    </member>
    <member