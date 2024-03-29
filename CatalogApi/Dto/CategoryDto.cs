﻿namespace CatalogApi.Dto;

public class CategoryDto : LinkedResourceBaseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int? ParentCategoryId { get; set; }
}
