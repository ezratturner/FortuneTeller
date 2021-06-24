terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 2.46.0"
    }
  }
}

provider "azurerm" {
  features {}
}
variable "services" {
  default = {
    "frontend"    = "et-frontend"
    "fortune"     = "et-fortune"
    "luckynumber" = "et-numbers"
    "merge"       = "et-merge"
  }
}

resource "azurerm_resource_group" "rg" {
  name     = "etproject"
  location = "uksouth"
  tags = {
    "project" = "true"
  }
}
resource "azurerm_app_service_plan" "app-service-plan" {
  name                = "ezra-appservice"
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location
  kind                = "Windows"
  reserved            = true
  sku {
    tier = "Basic"
    size = "B1"
  }
}
resource "azurerm_app_service" "webapp" {

  for_each            = var.services
  name                = each.value
  resource_group_name = azurerm_resource_group.rg.name
  location            = azurerm_resource_group.rg.location
  app_service_plan_id = azurerm_app_service_plan.app-service-plan.id
}
