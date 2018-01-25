<?php

use Illuminate\Database\Seeder;
use App\Models\Task;

class TaskTableSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        Task::create([
            'name' => 'Wymiana żarówki',
            'description' => 'Wymiana żarówki w garderobie',
            'location' => 'c115',
            'section_id' => '3'
          ]);
		Task::create([
            'name' => 'Sprzątanie pokoju',
            'description' => 'Całościowe sprzątanie pokoju przed wizytą gości',
            'location' => 'pokój 27',
            'section_id' => '4'
          ]);
		Task::create([
            'name' => 'Uzupełnienie zapasów w magazynie',
            'description' => 'Należy uzupełnić zapasy żywności w magazynie',
            'location' => 'magazyn',
            'section_id' => '2'
          ]);
    }
}
