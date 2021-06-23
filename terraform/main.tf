terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "2.46.0"
    }
  }
}

variable "services" {
  default = {
    "et-luckynumber" = "et-luckynumber"
    "et-fortune"     = "et-fortune"
    "et-merge"       = "et-merge"
    "et-frontend"    = "et-frontend"
  }
}

provider "azurerm" {
  features {}
}

resource "azurerm_resource_group" "main" {
  # creating a rg name here
  name     = "ett-tf-rg"
  location = "uksouth"

}

resource "azurerm_app_service_plan" "master" {
  name     = "ezra-appservice"
  location = azurerm_resource_group.rg.location
  kind     = "Windows"
  reserved = false

  resource_group_name = azurerm_resource_group.rg.name
  sku {
    tier = "Basic"
    size = "B1"
  }
}

resource "azurerm_app_service" "master" {

  for_each            = var.services
  name                = each.value
  location            = azurerm_resource_group.rg.location
  resource_group_name = azurerm_resource_group.rg.name
  app_service_plan_id = azurerm_app_service_plan.master.id

  site_config {
    dotnet_framework_version = "v5.0"
  }

}




