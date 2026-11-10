<?php

use App\Http\Controllers\AuthController;
use App\Http\Controllers\PetugasController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('form_login');
});

route::post('form_login',[AuthController::class,'login']);
route::get('form_tambah_petugas',[PetugasController::class,'tampil']);
route::get('form_tambah_petugas',[PetugasController::class,'tambah']);



