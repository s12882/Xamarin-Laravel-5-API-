<?php

use App\Models\Section;
use Illuminate\Database\Seeder;

class SectionSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        $section = Section::create([
          'name' => env('FACILITY_NAME'),
		  'left' => 1,
		  'right' => 8
        ]);
		
		Section::create([
          'name' => 'Gastronomiczny',
		  'parent_id' => 1,
		  'left' => 2,
		  'right' => 3
        ]);
		
		Section::create([
          'name' => 'Techniczny',
		  'parent_id' => 1,
		  'left' => 4,
		  'right' => 5
        ]);
		
		Section::create([
          'name' => 'Sprzątanie',
		  'parent_id' => 1,
		  'left' => 6,
		  'right' => 7
        ]);
    }
}
