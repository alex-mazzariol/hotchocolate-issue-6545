using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace HCSample;

public class Query
{
    [UsePaging(IncludeTotalCount = true, MaxPageSize = 100)]
    [UseSorting(typeof(UserSortInputType))]
    public IQueryable<User> GetUsers([Service] AppDbContext context) => context.Users;
}