BEGIN TRANSACTION;

CREATE TABLE "Crests" (
	"Id"	integer NOT NULL,
	"CityName"	nvarchar,
	"SmallImage"	image,
	"LargeImage"	image,
	PRIMARY KEY("Id")
);

CREATE TABLE "Customers" (
	"Id"	integer NOT NULL,
	"Name"	nvarchar NOT NULL,
	"HomeOffice_Line"	nvarchar,
	"HomeOffice_City"	nvarchar,
	"HomeOffice_State"	int,
	"HomeOffice_Latitude"	float,
	"HomeOffice_Longitude"	float,
	"HomeOffice_ZipCode"	nvarchar,
	"BillingAddress_Line"	nvarchar,
	"BillingAddress_City"	nvarchar,
	"BillingAddress_State"	int,
	"BillingAddress_Latitude"	float,
	"BillingAddress_Longitude"	float,
	"BillingAddress_ZipCode"	nvarchar,
	"HomeOfficeLine"	nvarchar,
	"HomeOfficeCity"	nvarchar,
	"HomeOfficeZipCode"	nvarchar,
	"BillingAddressLine"	nvarchar,
	"BillingAddressCity"	nvarchar,
	"BillingAddressZipCode"	nvarchar,
	"HomeOfficeState"	int NOT NULL,
	"HomeOfficeLatitude"	float NOT NULL,
	"HomeOfficeLongitude"	float NOT NULL,
	"BillingAddressState"	int NOT NULL,
	"BillingAddressLatitude"	float NOT NULL,
	"BillingAddressLongitude"	float NOT NULL,
	"Phone"	nvarchar,
	"Fax"	nvarchar,
	"Website"	nvarchar,
	"AnnualRevenue"	decimal NOT NULL,
	"TotalStores"	int NOT NULL,
	"TotalEmployees"	int NOT NULL,
	"Status"	int NOT NULL,
	"Profile"	nvarchar,
	"Logo"	image,
	PRIMARY KEY("Id")
);

CREATE TABLE "CustomerCommunications" (
	"Id"	integer NOT NULL,
	"EmployeeId"	integer,
	"CustomerEmployeeId"	integer,
	"Date"	datetime NOT NULL,
	"Type"	nvarchar,
	"Purpose"	nvarchar,
	PRIMARY KEY("Id")
);

CREATE TABLE "CustomerEmployees" (
	"Id"	integer NOT NULL,
	"FirstName"	nvarchar NOT NULL,
	"LastName"	nvarchar NOT NULL,
	"FullName"	nvarchar,
	"Prefix"	int NOT NULL,
	"MobilePhone"	nvarchar NOT NULL,
	"Email"	nvarchar NOT NULL,
	"PictureId"	integer,
	"CustomerId"	integer,
	"CustomerStoreId"	integer,
	"Position"	nvarchar,
	"IsPurchaseAuthority"	bit NOT NULL,
	PRIMARY KEY("Id")
);

CREATE TABLE "CustomerStores" (
	"Id"	integer NOT NULL,
	"CustomerId"	integer,
	"Address_Line"	nvarchar,
	"Address_City"	nvarchar,
	"Address_State"	int,
	"Address_Latitude"	float,
	"Address_Longitude"	float,
	"Address_ZipCode"	nvarchar,
	"Address_Line1"	nvarchar,
	"Address_City1"	nvarchar,
	"Address_State1"	int NOT NULL,
	"Address_ZipCode1"	nvarchar,
	"Address_Latitude1"	float NOT NULL,
	"Address_Longitude1"	float NOT NULL,
	"Phone"	nvarchar,
	"Fax"	nvarchar,
	"TotalEmployees"	int NOT NULL,
	"SquereFootage"	int NOT NULL,
	"AnnualSales"	decimal NOT NULL,
	"CrestId"	integer,
	"Location"	nvarchar,
	PRIMARY KEY("Id")
);

CREATE TABLE "DatabaseVersions" (
	"Id"	integer NOT NULL,
	"Date"	datetime NOT NULL,
	PRIMARY KEY("Id")
);

CREATE TABLE "Employees" (
	"Id"	integer NOT NULL,
	"Department"	int NOT NULL,
	"Title"	nvarchar NOT NULL,
	"Status"	int NOT NULL,
	"HireDate"	datetime,
	"PersonalProfile"	nvarchar,
	"ProbationReason_Id"	integer,
	"FirstName"	nvarchar NOT NULL,
	"LastName"	nvarchar NOT NULL,
	"FullName"	nvarchar,
	"Prefix"	int NOT NULL,
	"HomePhone"	nvarchar,
	"MobilePhone"	nvarchar NOT NULL,
	"Email"	nvarchar NOT NULL,
	"Skype"	nvarchar,
	"BirthDate"	datetime,
	"PictureId"	integer,
	"Address_Line"	nvarchar,
	"Address_City"	nvarchar,
	"Address_State"	int,
	"Address_Latitude"	float,
	"Address_Longitude"	float,
	"Address_ZipCode"	nvarchar,
	"AddressLine"	nvarchar,
	"AddressCity"	nvarchar,
	"AddressZipCode"	nvarchar,
	"AddressState"	int NOT NULL,
	"AddressLatitude"	float NOT NULL,
	"AddressLongitude"	float NOT NULL,
	PRIMARY KEY("Id")
);
CREATE TABLE "EmployeeEmployeeTasks" (
	"Employee_Id"	integer NOT NULL,
	"EmployeeTask_Id"	integer NOT NULL,
	PRIMARY KEY("Employee_Id","EmployeeTask_Id")
);
CREATE TABLE "EmployeeTasks" (
	"Id"	integer NOT NULL,
	"Subject"	nvarchar NOT NULL,
	"Description"	nvarchar,
	"RtfTextDescription"	nvarchar,
	"StartDate"	datetime,
	"DueDate"	datetime,
	"Status"	int NOT NULL,
	"Priority"	int NOT NULL,
	"Completion"	int NOT NULL,
	"Reminder"	bit NOT NULL,
	"ReminderDateTime"	datetime,
	"AssignedEmployeeId"	integer,
	"OwnerId"	integer,
	"CustomerEmployeeId"	integer,
	"FollowUp"	int NOT NULL,
	"Private"	bit NOT NULL,
	"Category"	nvarchar,
	"AttachedCollectionsChanged"	bit NOT NULL,
	"ParentId"	integer,
	"Predecessors"	nvarchar,
	PRIMARY KEY("Id")
);
CREATE TABLE "Evaluations" (
	"Id"	integer NOT NULL,
	"CreatedById"	integer,
	"CreatedOn"	datetime NOT NULL,
	"EmployeeId"	integer,
	"Subject"	nvarchar,
	"Details"	nvarchar,
	"Rating"	int NOT NULL,
	PRIMARY KEY("Id")
);
CREATE TABLE "Orders" (
	"Id"	integer NOT NULL,
	"InvoiceNumber"	nvarchar,
	"CustomerId"	integer,
	"StoreId"	integer,
	"PONumber"	nvarchar,
	"EmployeeId"	integer,
	"OrderDate"	datetime NOT NULL,
	"SaleAmount"	decimal NOT NULL,
	"ShippingAmount"	decimal NOT NULL,
	"TotalAmount"	decimal NOT NULL,
	"ShipDate"	datetime,
	"ShipMethod"	int NOT NULL,
	"OrderTerms"	nvarchar,
	"ShipmentCourier"	int NOT NULL,
	"ShipmentCourierId"	nvarchar,
	"ShipmentStatus"	int NOT NULL,
	"Comments"	nvarchar,
	"RefundTotal"	decimal NOT NULL,
	"PaymentTotal"	decimal NOT NULL,
	PRIMARY KEY("Id")
);
CREATE TABLE "OrderItems" (
	"Id"	integer NOT NULL,
	"OrderId"	integer,
	"ProductId"	integer,
	"ProductUnits"	int NOT NULL,
	"ProductPrice"	decimal NOT NULL,
	"Discount"	decimal NOT NULL,
	"Total"	decimal NOT NULL,
	PRIMARY KEY("Id")
);
CREATE TABLE "Pictures" (
	"Id"	integer NOT NULL,
	"Data"	image,
	PRIMARY KEY("Id")
);
CREATE TABLE "Probations" (
	"Id"	integer NOT NULL,
	"Reason"	nvarchar,
	PRIMARY KEY("Id")
);
CREATE TABLE "Products" (
	"Id"	integer NOT NULL,
	"Name"	nvarchar,
	"Description"	nvarchar,
	"ProductionStart"	datetime NOT NULL,
	"Available"	bit NOT NULL,
	"Image"	image,
	"SupportId"	integer,
	"EngineerId"	integer,
	"CurrentInventory"	int,
	"Backorder"	int NOT NULL,
	"Manufacturing"	int NOT NULL,
	"Barcode"	image,
	"PrimaryImageId"	integer,
	"Cost"	decimal NOT NULL,
	"SalePrice"	decimal NOT NULL,
	"RetailPrice"	decimal NOT NULL,
	"Weight"	float NOT NULL,
	"ConsumerRating"	float NOT NULL,
	"Category"	int NOT NULL,
	PRIMARY KEY("Id")
);
CREATE TABLE "ProductCatalogs" (
	"Id"	integer NOT NULL,
	"ProductId"	integer,
	"PDF"	image,
	PRIMARY KEY("Id")
);
DROP TABLE IF EXISTS "ProductImages";
CREATE TABLE "ProductImages" (
	"Id"	integer NOT NULL,
	"PictureId"	integer,
	"ProductId"	integer,
	PRIMARY KEY("Id")
);
CREATE TABLE "Quotes" (
	"Id"	integer NOT NULL,
	"Number"	nvarchar,
	"CustomerId"	integer,
	"CustomerStoreId"	integer,
	"EmployeeId"	integer,
	"Date"	datetime NOT NULL,
	"SubTotal"	decimal NOT NULL,
	"ShippingAmount"	decimal NOT NULL,
	"Total"	decimal NOT NULL,
	"Opportunity"	float NOT NULL,
	PRIMARY KEY("Id")
);
CREATE TABLE "QuoteItems" (
	"Id"	integer NOT NULL,
	"QuoteId"	integer,
	"ProductId"	integer,
	"ProductUnits"	int NOT NULL,
	"ProductPrice"	decimal NOT NULL,
	"Discount"	decimal NOT NULL,
	"Total"	decimal NOT NULL,
	PRIMARY KEY("Id")
);
CREATE TABLE "States" (
	"ShortName"	int NOT NULL,
	"LongName"	nvarchar,
	"Flag48px"	image,
	"Flag24px"	image,
	PRIMARY KEY("ShortName")
);
CREATE TABLE "TaskAttachedFiles" (
	"Id"	integer NOT NULL,
	"EmployeeTaskId"	integer,
	"Name"	nvarchar,
	"Content"	image,
	PRIMARY KEY("Id")
);
COMMIT;
