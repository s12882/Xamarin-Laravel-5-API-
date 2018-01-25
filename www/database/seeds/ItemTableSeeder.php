<?php

use Illuminate\Database\Seeder;
use App\Models\Item;

class ItemTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        Item::create([
            'name' => 'Żarówka LED',
            'type' => 'GU 10 ',
            'amount' => '15',
            'ean' => '4052899949683',
            'category_id' => 1
          ]);
		  
		Item::create([
            'name' => 'Chleb',
            'type' => 'Pieczywo',
            'amount' => '3',
            'ean' => '5900784205095',
            'category_id' => 2
          ]);
		  
		Item::create([
            'name' => 'Mleko',
            'type' => 'Nabiał',
            'amount' => '1',
            'ean' => '125002741350',
            'category_id' => 2
          ]);

    }
}
