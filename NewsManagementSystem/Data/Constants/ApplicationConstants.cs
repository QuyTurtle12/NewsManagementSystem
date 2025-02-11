﻿namespace Data.Constants;

public class ApplicationConstants
{
    public const string KEYID_EXISTED = "KeyId {0} đã tồn tại.";
    public const string KeyId = "KeyId";
    public const string DUPLICATE = "Symtem_id is duplicated";
    public const int BREAK_TIME = 1;
    public const int WORKINGSTEP = 1;
}

public class ResponseCodeConstants
{
    public const string NOT_FOUND = "Not found!";
    public const string SUCCESS = "Success!";
    public const string FAILED = "Failed!";
    public const string EXISTED = "Existed!";
    public const string DUPLICATE = "Duplicate!";
    public const string INTERNAL_SERVER_ERROR = "INTERNAL_SERVER_ERROR";
    public const string INVALID_INPUT = "Invalid input!";
    public const string UNAUTHORIZED = "Unauthorized!";
    public const string FORBIDDEN = "Forbidden!";
    public const string BADREQUEST = "Bad request!";
    //Kiểm tra số lượng 
    public const string INVALID_QUANTITY = "Invalid quantity! Quantity must be greater than 0.";
    // Kiểm tra số tiền
    public const string INVALID_PRICE = "Invalid price! Price must be greater than 0.";
    // Kiểm tra ngày
    public const string INVALID_DATE = "Invalid date!";
}