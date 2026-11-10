<?php

namespace App\Http\Controllers;

use App\Models\Petugas;
use Illuminate\Http\Request;

class PetugasController extends Controller
{
    public function login(Request $request ){
       return view('dashboard',[
            'data_petugas'=>Petugas::find()
       ]);
    }
    public function tampil(){
        
    }
    public function tambah(){
        petugas::create()->all();

        redirect('form_tambah_petugas')->with('pesan','berhasil');
    }

}
