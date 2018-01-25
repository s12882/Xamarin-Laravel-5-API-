<?php

use Illuminate\Database\Seeder;
use App\Models\ItemCategory;

class ItemCategorySeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        ItemCategory::create([
            'name' => 'Oświetlenie'
          ]);
		 
		ItemCategory::create([
            'name' => 'Żywność'
          ]);
		  
		ItemCategory::create([
            'name' => 'Części'
          ]);
    }
}
