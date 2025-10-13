// Nested If-else statement
if (totalAmount > 100)
{
    if (isMember)
    {
        applyMemberDiscount();
    }
    else
    {
        applyRegularDiscount();
    }
}
else
{
    applyNoDiscount();
}

// Nested If-else statement
if (location == "local")
{
    applyLocalShipping();
}
else if (location == "domestic")
{
    applyDomesticShipping();
}
else
{
    applyInternationalShipping();
}

// Decision-Making Scene
switch (location)
{
    case "local":
        appluLocalShipping();
        break;
    case "domestic":
        applyDomesticShippping();
        break;
    case "international":
        applyInternationalShipping();
        break;
    default:
        applyStandardShipping();
        break;            
}