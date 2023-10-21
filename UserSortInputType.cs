using HotChocolate.Data.Sorting;

namespace HCSample;

public class UserSortInputType : SortInputType<User>
{
    protected override void Configure(ISortInputTypeDescriptor<User> descriptor)
    {
        descriptor.BindFieldsImplicitly();

        descriptor.Field(u => u.Addresses.FirstOrDefault(a => a.Id % 2 == 0))
            .Type<AddressSortInputType>()
            .Name("evenNumberedAddress");
    }
}