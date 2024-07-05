namespace Catalog.Infrastructure.IntegrationEvents;

public sealed record CatalogItemDeletedEvent
(
    string Slug
);