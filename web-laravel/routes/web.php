<?php

use App\Http\Controllers\AuthController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('form_login');
});

route::get('dashboard',[AuthController::class,'login']);


