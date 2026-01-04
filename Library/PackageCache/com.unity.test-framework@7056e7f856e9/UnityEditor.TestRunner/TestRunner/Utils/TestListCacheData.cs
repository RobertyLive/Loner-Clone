# EscapableHandleScope

The `Napi::EscapableHandleScope` class is used to manage the lifetime of object handles
which are created through the use of node-addon-api. These handles
keep an object alive in the heap in order to ensure that the objects
are not collected by the garbage collector while native code is using them.
A handle may be created when any new node-addon-api Value or one
of its subclasses is created or returned.

The `Napi::EscapableHandleScope` is a special type of `Napi::HandleScope`
which allows a single handle to be "promoted" to an outer scope.

For more details refer to the section titled
[Object lifetime management](object_lifetime_management.md).

##