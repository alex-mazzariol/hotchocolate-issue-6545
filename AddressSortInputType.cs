using HotChocolate.Data.Sorting;

namespace HCSample;

public class AddressSortInputType : SortInputType<Address>
{
    protected override void Configure(ISortInputTypeDescriptor<Address> descriptor)
    {
        descriptor.BindFieldsImplicitly();
    }
}